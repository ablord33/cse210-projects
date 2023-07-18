using System.Collections.Generic;

namespace YouTubeMonitoring
{
    public class Video
    {
        private string title;
        private string author;
        private int length;
        private List<Comment> comments;

        public Video(string title, string author, int length)
        {
            this.title = title;
            this.author = author;
            this.length = length;
            comments = new List<Comment>();
        }

        public void AddComment(string commenterName, string commentText)
        {
            Comment comment = new Comment(commenterName, commentText);
            comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public void DisplayVideoDetails()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Length: " + length + " seconds");
            Console.WriteLine("Number of Comments: " + GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in comments)
            {
                Console.WriteLine("Name: " + comment.CommenterName);
                Console.WriteLine("Text: " + comment.CommentText);
                Console.WriteLine();
            }
        }
    }
}
