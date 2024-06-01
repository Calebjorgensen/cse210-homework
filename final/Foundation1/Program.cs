using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Creed3", "By Caleb", 5.4);

        Comment video1Comment1 = new Comment("Caleb","This video is great");
        Comment video1Comment2 = new Comment("Elle", "This is great");
        Comment video1Comment3 = new Comment("Paul", "Why is this in error");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videoList.Add(video1);

        Video video2 = new Video("How to run halo misson", "By Elle", 6.4);

        Comment video2Comment1 = new Comment("Elle", "What a perfect way of doing that");
        Comment video2Comment2 = new Comment("Paul", "This was horrible it didn't help out with the mission at all");
        Comment video2Comment3 = new Comment("Greg", "Thanks for creating this video it helps so much");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videoList.Add(video2);

        foreach(Video video in videoList)
        {
            video.DisplayInfo();
        }
    }
}