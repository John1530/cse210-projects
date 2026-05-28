using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How Airplanes Fly", "John Aviation", 600);
        video1.AddComment(new Comment("Alex", "Very informative video!"));
        video1.AddComment(new Comment("Sarah", "Loved the explanation."));
        video1.AddComment(new Comment("Mike", "Can you make more aerospace videos?"));

        Video video2 = new Video("C# Classes Tutorial", "Code Master", 900);
        video2.AddComment(new Comment("Emma", "This helped me a lot."));
        video2.AddComment(new Comment("Chris", "Great explanation of abstraction."));
        video2.AddComment(new Comment("Daniel", "Awesome tutorial!"));

        Video video3 = new Video("UAV Technology", "Drone Labs", 750);
        video3.AddComment(new Comment("Ryan", "Amazing drone content."));
        video3.AddComment(new Comment("Olivia", "Very detailed video."));
        video3.AddComment(new Comment("Sophia", "Thanks for sharing!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}