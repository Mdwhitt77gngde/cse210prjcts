using System;
using System.Collections.Generic;

public class Playlist
{
    public string PlaylistName { get; set; }
    public List<Video> VideosList { get; set; }
    public string CreatedBy { get; set; }

    public Playlist(string name, string createdBy)
    {
        PlaylistName = name;
        CreatedBy = createdBy;
        VideosList = new List<Video>();
    }

    public void AddVideo(Video video) => VideosList.Add(video);
    public void RemoveVideo(Video video) => VideosList.Remove(video);
    public void PlayAll() => Console.WriteLine($"Playing all videos in {PlaylistName}");
    public void ShufflePlay() => Console.WriteLine($"Shuffling playlist {PlaylistName}");
}
