// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.title = title;
        Random rand = new Random();
        this.id = rand.Next(1000, 99999);
        this.playCount = 0;
    }
    public void IncreasePlaycount(int playCount)
    {
        this.playCount += playCount;
    }
    public void printVideoDetails()
    {
        Console.WriteLine("ID Video: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);

    }
}

class Program
{
    static void Main()
    {
        SayaTubeVideo stVideo = new SayaTubeVideo("Tutorial Design By Contract - Nawra Nazli Kirana");
        stVideo.IncreasePlaycount(50);
        stVideo.printVideoDetails();
    }
}

