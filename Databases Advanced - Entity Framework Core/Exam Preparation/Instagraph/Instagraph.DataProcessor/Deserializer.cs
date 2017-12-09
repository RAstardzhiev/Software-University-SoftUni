using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

using Newtonsoft.Json;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

using Instagraph.Data;
using Instagraph.Models;
using Instagraph.DataProcessor.Dtos.Import;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.IO;

namespace Instagraph.DataProcessor
{
    public class Deserializer
    {
        private const string SuccessMessage = "Successfully imported {0} {1}.";
        private const string SuccessFollowerMessage = "Successfully imported Follower {0} to User {1}.";
        private const string ErrorMessage = "Error: Invalid data.";

        public static string ImportPictures(InstagraphContext context, string jsonString)
        {
            var deserializedPictures = JsonConvert.DeserializeObject<PictureDto[]>(jsonString);

            var sb = new StringBuilder();

            var validPictures = new List<Picture>();
            foreach (var dto in deserializedPictures)
            {
                if (!IsValid(dto) || 
                    validPictures.Any(p => p.Path.Equals(dto.Path, StringComparison.OrdinalIgnoreCase)))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var picture = Mapper.Map<Picture>(dto);
                validPictures.Add(picture);
                sb.AppendLine(string.Format(SuccessMessage, nameof(Picture), picture.Path));
            }

            context.Pictures.AddRange(validPictures);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportUsers(InstagraphContext context, string jsonString)
        {
            var deserializedUsers = JsonConvert.DeserializeObject<UserDto[]>(jsonString);

            var sb = new StringBuilder();

            var validUsers = new List<User>();
            foreach (var dto in deserializedUsers)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var profilePicture = context.Pictures
                    .SingleOrDefault(p => p.Path.Equals(dto.ProfilePicture, StringComparison.OrdinalIgnoreCase));

                if (profilePicture == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var user = new User
                {
                    Username = dto.Username,
                    Password = dto.Password,
                    ProfilePicture = profilePicture
                };

                validUsers.Add(user);
                sb.AppendLine(string.Format(SuccessMessage, nameof(User), user.Username));
            }

            context.Users.AddRange(validUsers);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportFollowers(InstagraphContext context, string jsonString)
        {
            var deserializedFollowers = JsonConvert.DeserializeObject<FollowerDto[]>(jsonString);

            var sb = new StringBuilder();

            var validFollowers = new List<UserFollower>();
            foreach (var dto in deserializedFollowers)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var user = context.Users
                    .SingleOrDefault(u => u.Username.Equals(dto.User, StringComparison.OrdinalIgnoreCase));
                if (user == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var follower = context.Users
                    .SingleOrDefault(u => u.Username.Equals(dto.Follower, StringComparison.OrdinalIgnoreCase));
                if (follower == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var isDuplicateEntry = validFollowers
                    .Any(uf => uf.UserId == user.Id && uf.FollowerId == follower.Id);
                if (isDuplicateEntry)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var mapping = new UserFollower
                {
                    UserId = user.Id, 
                    FollowerId = follower.Id
                };

                validFollowers.Add(mapping);
                sb.AppendLine(string.Format(SuccessFollowerMessage, dto.Follower, dto.User));
            }

            context.UsersFollowers.AddRange(validFollowers);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportPosts(InstagraphContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(PostDto[]), new XmlRootAttribute("posts"));
            var deserializedPosts = (PostDto[])serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));

            var sb = new StringBuilder();

            var validPosts = new List<Post>();
            foreach (var dto in deserializedPosts)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var user = context.Users
                    .SingleOrDefault(u => u.Username.Equals(dto.Username, StringComparison.OrdinalIgnoreCase));
                if (user == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var picture = context.Pictures
                    .SingleOrDefault(p => p.Path.Equals(dto.PicturePath, StringComparison.OrdinalIgnoreCase));
                if (picture == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var post = new Post
                {
                    PictureId = picture.Id, 
                    Caption = dto.Caption, 
                    UserId = user.Id
                };

                validPosts.Add(post);
                sb.AppendLine(string.Format(SuccessMessage, nameof(Post), dto.Caption));
            }

            context.Posts.AddRange(validPosts);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportComments(InstagraphContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(CommentDto[]), new XmlRootAttribute("comments"));
            var deserializedComments = (CommentDto[])serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));

            var sb = new StringBuilder();

            var validComments = new List<Comment>();
            foreach (var dto in deserializedComments)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var user = context.Users
                    .SingleOrDefault(u => u.Username.Equals(dto.Username, StringComparison.OrdinalIgnoreCase));
                if (user == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var post = context.Posts
                    .FirstOrDefault(p => p.Id == dto.Post.Id);
                if (post == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var comment = new Comment
                {
                    Content = dto.Content,
                    UserId = user.Id, 
                    PostId = post.Id
                };

                validComments.Add(comment);
                sb.AppendLine(string.Format(SuccessMessage, nameof(Comment), comment.Content));
            }

            context.Comments.AddRange(validComments);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationresult = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(obj, validationContext, validationresult, true);
            return isValid;
        }
    }
}
