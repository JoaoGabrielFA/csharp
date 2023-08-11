class Episode
{
    private List<string> guests = new List<string>();

    public Episode(int order, string name, int duration)
    {
        Order = order;
        Name = name;
        Duration = duration;
    }

    public int Order { get; }
    public String Name { get; }
    public int Duration { get; }
    
    public string Overview => $"{Order}. In this episode, we will talk about {Name} ({Duration}min - {string.Join(", ", guests)}).";

    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }
}