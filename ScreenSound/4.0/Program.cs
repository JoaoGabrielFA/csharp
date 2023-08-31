using ScreenSound_04.Modelos;
using ScreenSound_04.Filtros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        //Console.WriteLine(response);

        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;

        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C#");

        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);
        //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        //var musicasPreferidasDaEmily = new MusicasPreferidas("Emily");
        //musicasPreferidasDaEmily.AdicionarMusicasFavoritas(musicas[7]);
        //musicasPreferidasDaEmily.AdicionarMusicasFavoritas(musicas[144]);
        //musicasPreferidasDaEmily.AdicionarMusicasFavoritas(musicas[300]);
        //musicasPreferidasDaEmily.AdicionarMusicasFavoritas(musicas[999]);
        //musicasPreferidasDaEmily.AdicionarMusicasFavoritas(musicas[1800]);
        //musicasPreferidasDaEmily.ExibirMusicasFavoritas();
        //musicasPreferidasDaEmily.GerarArquivoJson();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"We have a problem: {ex.Message}");
    }
}
