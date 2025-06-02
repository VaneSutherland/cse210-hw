using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 30 Minutes", "CodeAcademy", 1800);
        video1.AddComment(new Comment("Alice", "This was super helpful!"));
        video1.AddComment(new Comment("Mary", "Clear explanation, thank you!"));
        video1.AddComment(new Comment("Carlos", "Can you make a part 2?"));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Programming Tips", "DevTalk", 900);
        video2.AddComment(new Comment("David", "Nice tips, especially #3."));
        video2.AddComment(new Comment("Emma", "Shared with my team."));
        video2.AddComment(new Comment("Frank", "Could use more depth."));
        videos.Add(video2);

        Video video3 = new Video("Debugging Basics", "Tech Simplified", 1200);
        video3.AddComment(new Comment("Alex", "Wish I saw this sooner!"));
        video3.AddComment(new Comment("Tomas", "Saved me hours, thanks!"));
        video3.AddComment(new Comment("Ivy", "Love your teaching style."));
        videos.Add(video3);

        Video video4 = new Video("What is OOP?", "CS Explained", 1500);
        video4.AddComment(new Comment("Vane", "Very clear and concise."));
        video4.AddComment(new Comment("Karen", "Helped me for my exam."));
        video4.AddComment(new Comment("Leo", "Nice visuals!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
