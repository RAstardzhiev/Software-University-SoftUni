using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Instagraph.Data;
using Instagraph.DataProcessor.Dtos.Export;
using Newtonsoft.Json;

namespace Instagraph.DataProcessor
{
    public class Serializer
    {
        public static string ExportUncommentedPosts(InstagraphContext context)
        {
            var posts = context.Posts
                .Where(p => p.Comments.Count == 0)
                .OrderBy(p => p.Id)
                .Select(p => new PostExportDto
                {
                    Id = p.Id, 
                    PicturePath = p.Picture.Path, 
                    Username = p.User.Username
                })
                .ToArray();

            var result = JsonConvert.SerializeObject(posts, Newtonsoft.Json.Formatting.Indented);
            return result;
        }

        public static string ExportPopularUsers(InstagraphContext context)
        {
            var users = context.Users
                .Where(u => u.Posts
                    .Any(p => p.Comments
                        .Select(c => c.UserId)
                        .Intersect(u.Followers
                            .Select(f => f.FollowerId))
                        .Any()))
                .OrderBy(u => u.Id)
                .Select(u => new
                {
                    u.Username,
                    Followers = u.Followers.Count
                })
                .ToArray();

            var result = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            return result;
        }

        public static string ExportCommentsOnPosts(InstagraphContext context)
        {
            var users = context.Users
                .Select(u => new 
                {
                    u.Username, 
                    TopPost = u.Posts
                        .OrderByDescending(p => p.Comments.Count)
                        .FirstOrDefault()
                })
                .Select(u => new UserExportDto
                {
                    Username =  u.Username, 
                    MostComments = u.TopPost.Comments == null 
                        ? 0 
                        : u.TopPost.Comments.Count
                })
                .OrderByDescending(u => u.MostComments)
                .ThenBy(u => u.Username)
                .ToArray();

            var sb = new StringBuilder();

            var serializer = new XmlSerializer(typeof(UserExportDto[]), new XmlRootAttribute("users"));
            serializer.Serialize(new StringWriter(sb), users, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));

            var result = sb.ToString();
            return result;
        }
    }
}
