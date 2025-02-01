using System;

public class Comment
{
    public string Author { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public int Likes { get; private set; }
    public int Dislikes { get; private set; }

    public Comment(string author, string content)
    {
        Author = author;
        Content = content;
        Timestamp = DateTime.Now;
    }

    public void Edit(string newContent) => Content = newContent;
    public void Delete() => Content = "[Deleted]";
    public void Like() => Likes++;
    public void Dislike() => Dislikes++;
}
