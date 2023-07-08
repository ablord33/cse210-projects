using System;
using System.Collections.Generic;

using Video = Video;
using Comment = Comment;

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video
        {
            Title = "Video 1",
            Author = "Author 1",
            Length = 180
        };

        Video video2 = new Video
        {
            Title = "Video 2",
            Author = "Author 2",
            Length = 240
        };

        // Add comments to video 1
        video1.AddComment("Comment 1 for Video 1");
        video1.AddComment("Comment 2 for Video 1");

        // Add comments to video 2
        video2.AddComment("Comment 1 for Video 2");
        video2.AddComment("Comment 2 for Video 2");

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2 };

        // Display video information and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}