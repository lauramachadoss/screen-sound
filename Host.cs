class Host
{
   private List<Podcast> podcasts = new List<Podcast>();
    
    public Host(string nome)
    {
        Nome = nome;
        
    }
    public string Nome { get;  } = "";

    public void AdicionarPodcast (Podcast podcast)
    {
        podcasts.Add(podcast);
    }

    public void ExibirListaEpisodios()
    {
        Console.WriteLine($"Episodios de {Nome}");
        foreach (Podcast podcast in podcasts)
        {
            Console.WriteLine($"Álbum: {podcast.Nome}");
        } 
    }
}