using System;

namespace YouTubeVideos
{
    public class Comment
    {
        private string author;
        private string text;

        public Comment(string author, string text)
        {
            this.author = author;
            this.text = text;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetText()
        {
            return text;
        }
    }
}
