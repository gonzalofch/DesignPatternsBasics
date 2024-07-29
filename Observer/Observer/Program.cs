namespace Observer;

class Program
{
    static async Task Main(string[] args)
    {
        User gonzalo = new User("Gonzalo");
        User miguel = new User("Miguel");
        User juan = new User("Juan");

        YoutubeChannel youtube = new YoutubeChannel();

        youtube.AddObserver(gonzalo);
        youtube.AddObserver(juan);

        //Simulacion de notificaciones

        var interval = TimeSpan.FromSeconds(4);
        var timer = new PeriodicTimer(interval);
        var cts = new CancellationTokenSource();

        cts.CancelAfter(TimeSpan.FromSeconds(17));

        var videoCounter = 1;
        List<string> VideosToUpload = new List<string>();
        
        try
        {
            while (await timer.WaitForNextTickAsync(cts.Token))
            {
                // Task to be executed periodically
                youtube.UploadNewVideo($"Nuevo video número {videoCounter}");
                videoCounter++;
                if (videoCounter>3)
                {
                    youtube.RemoveObserver(gonzalo);
                }
            }
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Fin.");
        }
    }
}