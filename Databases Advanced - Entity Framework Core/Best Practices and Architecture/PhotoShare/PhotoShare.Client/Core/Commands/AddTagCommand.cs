namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using Models;
    using PhotoShare.Client.Interfaces;
    using PhotoShare.Data;
    using Utilities;

    public class AddTagCommand : ICommand
    {
        private const string TagExistsExceptionMessage = "Tag {0} exists!";

        private const string SuccessfulAddedTag = "Tag {0} was added successfully!";

        private PhotoShareContext context;

        public AddTagCommand(PhotoShareContext context) 
        {
            this.context = context;
        }

        // AddTag <tag>
        public string Execute(string[] data)
        {
            string tagName = data[0].ValidateOrTransform();
            var tag = this.context.Tags
                .SingleOrDefault(t => t.Name.Equals(tagName, StringComparison.OrdinalIgnoreCase));

            if (tag != null)
            {
                throw new ArgumentException(string.Format(TagExistsExceptionMessage, tagName));
            }

            this.context.Tags.Add(new Tag(tagName));
            this.context.SaveChanges();

            return string.Format(SuccessfulAddedTag, tagName);
        }
    }
}
