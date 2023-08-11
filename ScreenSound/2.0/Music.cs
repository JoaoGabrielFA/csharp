class Music
{
    public Music(Band artist, string name) 
    {
        Artist = artist;
        Name = name;
    }

    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Avaliable { get; set; }
    public string Description => 
        $"The music {Name} is from {Artist}";

    public void DisplayTechnicalSheet()
    {
        Console.WriteLine($"\nTitle: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration}");
        if (Avaliable) Console.WriteLine($"Avaliable: Yes");
        else Console.WriteLine($"Avaliable: No");
    }
}