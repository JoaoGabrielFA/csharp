class Band
{
    private List<Album> albums = new List<Album>();
    public string Name { get; }

    public Band(string name)
    {
        Name = name;    
    }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"{Name} discography.\n");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Name} ({album.Duration})");
        }
    }
}