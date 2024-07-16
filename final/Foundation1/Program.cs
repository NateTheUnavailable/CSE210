using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }
}

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video
        {
            Title = "Video 1 Title",
            Author = "Author 1",
            LengthSeconds = 300, // 5 minutes
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "User1", Text = "Comment 1 for Video 1" },
                new Comment { CommenterName = "User2", Text = "Comment 2 for Video 1" },
                new Comment { CommenterName = "User3", Text = "Comment 3 for Video 1" }
            }
        };
        videos.Add(video1);

        // Create Video 2
        Video video2 = new Video
        {
            Title = "Video 2 Title",
            Author = "Author 2",
            LengthSeconds = 240, // 4 minutes
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "User4", Text = "Comment 1 for Video 2" },
                new Comment { CommenterName = "User5", Text = "Comment 2 for Video 2" }
            }
        };
        videos.Add(video2);

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}