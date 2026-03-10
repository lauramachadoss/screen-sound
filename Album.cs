class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set;} = "";
    public int DuraçãoTotal => musicas.Sum(m => m.Duração);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Esse álbum tema duração de: {DuraçãoTotal} segundos");
    }
}