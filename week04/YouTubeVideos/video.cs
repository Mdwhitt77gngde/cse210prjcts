using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Description { get; set; }
    public double Duration { get; set; }
    public int Views { get; private set; }
    public int Likes { get; private set; }
    public int Dislikes { get; private set; }
    public DateTime UploadDate { get; set; }
    public List<Comment> CommentsList { get; set; }

    public Video(string title, string description, double duration)
    {
        Title = title;
        Description = description;
        Duration = duration;
        UploadDate = DateTime.Now;
        CommentsList = new List<Comment>();
    }

    public void Play() => Console.WriteLine($"Playing: {Title}");
    public void Pause() => Console.WriteLine($"Paused: {Title}");
    public void Like() => Likes++;
    public void Dislike() => Dislikes++;
    public void Comment(Comment comment) => CommentsList.Add(comment);
    public void Share() => Console.WriteLine($"Shared: {Title}");
}
