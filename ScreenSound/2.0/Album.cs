class Album 
{ 
    private List<Music> musics = new List<Music>();

    public Album(string title)
    {
        Name = title;
    }

    public string Name { get; }
    public int Duration => musics.Sum(m => m.Duration);

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowAlbumMusics()
    {
        Console.WriteLine($"Music list of the album: {Name}.\n");
        foreach (Music music in musics)
        {
            Console.WriteLine($"Music: {music.Name}");
        }
        Console.WriteLine($"\nThis album have {Duration} seconds");
    }
}