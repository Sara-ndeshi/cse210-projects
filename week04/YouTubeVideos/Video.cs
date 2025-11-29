using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        private string title;
        private string author;
        private int lengthSeconds;
        private List<Comment> comments;

        public Video(string title, string author, int lengthSeconds)
        {
            this.title = title;
            this.author = author;
            this.lengthSeconds = lengthSeconds;
            this.comments = new List<Comment>();
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public int GetLength()
        {
            return lengthSeconds;
        }

        public void AddComment(Comment c)
        {
            comments.Add(c);
        }

        public int GetCommentCount()
        {
            return comments.Count;
        }

        public List<Comment> GetComments()
        {
            // Return the actual list 
            return comments;
        }
    }
}
