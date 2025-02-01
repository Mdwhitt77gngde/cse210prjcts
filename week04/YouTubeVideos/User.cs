using System;
using System.Collections.Generic;

public class User
{
    public string Username { get; set; }
    public string Email { get; set; }
    public List<Channel> SubscriptionsList { get; set; }
    public List<Video> WatchHistory { get; set; }

    public User(string username, string email)
    {
        Username = username;
        Email = email;
        SubscriptionsList = new List<Channel>();
        WatchHistory = new List<Video>();
    }

    public void Login() => Console.WriteLine($"{Username} logged in.");
    public void Logout() => Console.WriteLine($"{Username} logged out.");
    public void SubscribeToChannel(Channel channel) => SubscriptionsList.Add(channel);
    public void WatchVideo(Video video) => WatchHistory.Add(video);
}
