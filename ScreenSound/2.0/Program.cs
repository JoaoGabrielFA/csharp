/*Album queenAlbum = new Album("A Night At The Opera");

Band queen = new Band("Queen");

Music music1 = new Music(queen, "Love Of My life")
{
    Duration = 213,
    Avaliable = true,
};

Music music2 = new Music(queen, "Bohemian Rhapsody")
{
    Duration = 354,
    Avaliable = false,
};

queenAlbum.AddMusic(music1);
queenAlbum.AddMusic(music2);

queen.AddAlbum(queenAlbum);
queen.ShowDiscography();*/

Podcast podcast1 = new("Conversa Sobre Rodas", "Relâmpago McQueen");

Episode episode1 = new(1, "Gasolina ou Diesel: Um bate papo sobre combustíveis e hulk", 50);
episode1.AddGuest("Optimus Prime");
episode1.AddGuest("Bublebee");

Episode episode2 = new(2, "Manual ou Automático: Por dentro da moda contemporânea", 50);
episode2.AddGuest("Herby 'O Fusca Turbinado'");
episode2.AddGuest("K.I.T.T.Y");

podcast1.AddEpisode(episode1);
podcast1.AddEpisode(episode2);

podcast1.ShowDetails();