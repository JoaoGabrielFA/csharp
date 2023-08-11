class Podcast
{
    private List<Episode> episodes = new List<Episode>();   

    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public String Name { get; }
    public String Host { get; }
    public int Episodes => episodes.Count;

public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"The podcast {Name} is hosted by {Host}.\n");
        foreach(Episode episode in episodes.OrderBy(e => e.Order))
        {
            Console.WriteLine(episode.Overview);
        }
        Console.WriteLine($"\nThis podcast have {Episodes} episodes");
    }
}