using System;
using System.Collections.Generic;

public class Channel
{
    public string ChannelName { get; set; }
    public int SubscribersCount { get; private set; }
    public List<Video> VideosList { get; set; }
    public string Description { get; set; }

    public Channel(string name, string description)
    {
        ChannelName = name;
        Description = description;
        VideosList = new List<Video>();
    }

    public void UploadVideo(Video video)
    {
        VideosList.Add(video);
        Console.WriteLine($"Video uploaded: {video.Title}");
    }

    public void DeleteVideo(Video video) => VideosList.Remove(video);
    public void Subscribe() => SubscribersCount++;
    public void Unsubscribe() => SubscribersCount--;
}
