using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold videos
            List<Video> videos = new List<Video>();

            // Video 1
            Video v1 = new Video("How to Make Pancakes", "KitchenKing", 320);
            v1.AddComment(new Comment("Alice", "Tried this, turned out great!"));
            v1.AddComment(new Comment("Bob", "Easy to follow."));
            v1.AddComment(new Comment("Carol", "What brand of pan did you use?"));
            videos.Add(v1);

            // Video 2
            Video v2 = new Video("Intro to C# - Beginner Tutorial", "CodeWithSam", 900);
            v2.AddComment(new Comment("Dave", "Very helpful for beginners."));
            v2.AddComment(new Comment("Eve", "Please make a follow-up on lists."));
            v2.AddComment(new Comment("Frank", "Nice pacing and clear examples."));
            videos.Add(v2);

            // Video 3
            Video v3 = new Video("Top 10 Travel Destinations 2025", "TravelNow", 600);
            v3.AddComment(new Comment("Grace", "I'm adding these to my bucket list!"));
            v3.AddComment(new Comment("Heidi", "Great cinematography."));
            v3.AddComment(new Comment("Ivan", "Any budget tips for Morocco?"));
            videos.Add(v3);

            // Video 4
            Video v4 = new Video("Guitar Basics: Chords for Beginners", "StrumStudio", 480);
            v4.AddComment(new Comment("Jill", "Finally, a clear explanation of G major."));
            v4.AddComment(new Comment("Ken", "Can you do a song tutorial next?"));
            v4.AddComment(new Comment("Liam", "Thanks for the chord charts!"));
            videos.Add(v4);

            // Display each video's details and the comments
            foreach (var video in videos)
            {
                Console.WriteLine("Title: " + video.GetTitle());
                Console.WriteLine("Author: " + video.GetAuthor());
                Console.WriteLine("Length (seconds): " + video.GetLength());
                Console.WriteLine("Number of comments: " + video.GetCommentCount());
                Console.WriteLine("Comments:");
                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine("  - " + comment.GetAuthor() + ": " + comment.GetText());
                }
                Console.WriteLine(new string('-', 40)); // separator
            }
        }
    }
}
