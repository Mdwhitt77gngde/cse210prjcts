using System;

class Program
{
    static void Main()
    {
        // Creating a new channel
        Channel myChannel = new Channel("Tech Explained", "Technology deep dives.");
        Console.WriteLine($"Channel Created: {myChannel.ChannelName}");

        // Uploading a video
        Video myVideo = new Video("C# Basics", "Introduction to C#", 10);
        myChannel.UploadVideo(myVideo);

        // Watching the video
        User user = new User("JohnDoe", "johndoe@example.com");
        user.WatchVideo(myVideo);
        Console.WriteLine($"{user.Username} watched {myVideo.Title}");

        // Liking the video
        myVideo.Like();
        Console.WriteLine($"{myVideo.Title} now has {myVideo.Likes} likes.");
    }
}
