// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100, "Judul video memiliki panjang maksimal 100 karakter dan tidak berupa null.");
        this.title = title;
        Random rand = new Random();
        this.id = rand.Next(1000, 99999);
        this.playCount = 0;
    }
    public void IncreasePlaycount(int playCount)
    {
        Debug.Assert(playCount > 0 && playCount <= 10000000, "Jumlah penambahan play count maksimal adalah 10.000.000 per panggilan.");

        try
        {
            checked
            {
                this.playCount += playCount;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer!");
        }
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
       
        for (int i = 0; i < 10; i++)
        {
            stVideo.IncreasePlaycount(10000000);
        }
        stVideo.printVideoDetails();
    }
}

