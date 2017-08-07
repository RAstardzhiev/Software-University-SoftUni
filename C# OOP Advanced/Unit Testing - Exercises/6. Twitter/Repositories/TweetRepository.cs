namespace _6.Twitter.Repositories
{
    using System;
    using System.IO;
    using Interfaces;

    public class TweetRepository : ITweetRepository
    {
        private const string ServerFileName = "Server.txt";
        private const string MessageSeparator = "<[<MessageSeparator>]>";
        private readonly string serverFullPath = Path.Combine(Environment.CurrentDirectory, ServerFileName);

        public void SaveTweet(string content) => File.AppendAllText(this.serverFullPath, $"{content}{MessageSeparator}");
    }
}
