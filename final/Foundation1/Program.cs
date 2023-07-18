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
            video1.AddComment("User1", "This video is great!");
            video1.AddComment("User2", "I learned a lot from this video.");
            video1.AddComment("User3", "Could you please make a follow-up video?");
            videos.Add(video1);

            Video video2 = new Video("Video 2", "Author 2", 180);
            video2.AddComment("User4", "Amazing content!");
            video2.AddComment("User5", "I have a question about the topic.");
            video2.AddComment("User6", "Thanks for sharing your knowledge.");
            videos.Add(video2);

            Video video3 = new Video("Video 3", "Author 3", 150);
            video3.AddComment("User7", "I didn't find the video helpful.");
            video3.AddComment("User8", "Can you provide more examples?");
            videos.Add(video3);

            // Display video details
            foreach (Video video in videos)
            {
                video.DisplayVideoDetails();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
