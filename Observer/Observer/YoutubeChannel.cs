using Observer.Interfaces;

namespace Observer;

public class YoutubeChannel : ConcreteObservable
{
    private string ChannelName = "Canal Youtube";

    public void UploadNewVideo(string videoName)
    {
        Console.WriteLine($"Upload Video : {videoName}");
        NotifyAll(videoName);
    }
}