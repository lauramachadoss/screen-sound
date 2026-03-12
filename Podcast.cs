class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, Host apresentador)
    {
        Nome = nome;
        Apresentador = apresentador;
    }

    public string Nome { get; }
    public Host Apresentador { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Apresentador}\n");
        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\nEsse Podcast possui: {TotalEpisodios} episodios");
    }
}