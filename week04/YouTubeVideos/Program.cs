using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning Python Basic", "CodeWithAlex", 600);

        Comment comment11 = new Comment("John", "Very helpful introduction");
        video1._comments.Add(comment11);
        Comment comment12 = new Comment("Mary", "This made Python easy to understand");
        video1._comments.Add(comment12);
        Comment comment13 = new Comment("Samuel", "Great explanations");
        video1._comments.Add(comment13);
        Comment comment14 = new Comment("Linda", "Looking forward to the next video");
        video1._comments.Add(comment14);


        Video video2 = new Video("Object-Oriented Programming Explained", "TechTutor", 840);

        Comment comment21 = new Comment("Daniel", "Abstraction finally makes sense");
        video2._comments.Add(comment21);
        Comment comment22 = new Comment("Grace", "Clear and simple examples");
        video2._comments.Add(comment22);
        Comment comment23 = new Comment("Micheal", "Best OOP video so far");
        video2._comments.Add(comment23);
        Comment comment24 = new Comment("Aisha", "Thanks for breaking it down");
        video2._comments.Add(comment24);


        Video video3 = new Video("Data Structures in Java", "DevMaster", 720);

        Comment comment31 = new Comment("Chris", "Arrays and lists explained well");
        video3._comments.Add(comment31);
        Comment comment32 = new Comment("Nina", "This helped my assignment");
        video3._comments.Add(comment32);
        Comment comment33 = new Comment("Paul", "Nice pacing");
        video3._comments.Add(comment33);
        Comment comment34 = new Comment("Esther", "Please make more Java videos");
        video3._comments.Add(comment34);


        Video video4 = new Video("Introduction to Algorithms", "AlgoSchool", 900);

        Comment comment41 = new Comment("Kevin", "Sorting algorithms are clearer now");
        video4._comments.Add(comment41);
        Comment comment42 = new Comment("Sophia", "Loved the visuals");
        video4._comments.Add(comment42);
        Comment comment43 = new Comment("Ibrahim", "Very informative");
        video4._comments.Add(comment43);
        Comment comment44 = new Comment("Ruth", "Easy to follow explanations");
        video4._comments.Add(comment44);

        List<Video> _videos = new List<Video>();
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);

        foreach(Video video in _videos)
        {
            Console.WriteLine($"Video Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comment on Video: {video.GetCommentCount()} comment(s)");

            Console.WriteLine();
            Console.WriteLine("Comments- Name: Comment");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine("--------------------------------");
        }
    }
}