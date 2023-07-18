using System;
using System.Collections.Generic;

namespace YouTubeMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create videos and add comments
            Video video1 = new Video("Video 1", "Author 1", 120);
            GetCommentsFromUser(video1);
            videos.Add(video1);

            Video video2 = new Video("Video 2", "Author 2", 180);
            GetCommentsFromUser(video2);
            videos.Add(video2);

            Video video3 = new Video("Video 3", "Author 3", 150);
            GetCommentsFromUser(video3);
            videos.Add(video3);

            // Display video details
            foreach (Video video in videos)
            {
                video.DisplayVideoDetails();
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static void GetCommentsFromUser(Video video)
        {
            Console.WriteLine("Enter comments for video - " + video.Title);
            Console.WriteLine("Press Enter key without input to finish entering comments.");

            while (true)
            {
                Console.Write("Commenter Name: ");
                string commenterName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(commenterName))
                    break;

                Console.Write("Comment Text: ");
                string commentText = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(commentText))
                    break;

                video.AddComment(commenterName, commentText);
            }
        }
    }
}
