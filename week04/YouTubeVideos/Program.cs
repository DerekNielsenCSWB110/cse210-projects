using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Very helpful!"));
        video1.AddComment(new Comment("Bob", "Great explanation."));
        video1.AddComment(new Comment("Charlie", "Loved the examples."));
        videos.Add(video1);

        Video video2 = new Video("Understanding Abstraction", "Tech World", 750);
        video2.AddComment(new Comment("Derek", "This finally makes sense."));
        video2.AddComment(new Comment("Emma", "Clear and concise."));
        video2.AddComment(new Comment("Frank", "Nice visuals."));
        videos.Add(video2);

        Video video3 = new Video("Object-Oriented Programming", "Dev Simplified", 900);
        video3.AddComment(new Comment("Grace", "Excellent overview."));
        video3.AddComment(new Comment("Henry", "Perfect for beginners."));
        video3.AddComment(new Comment("Ivy", "Very informative."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}