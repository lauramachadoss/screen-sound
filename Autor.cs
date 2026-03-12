class Autor
{
   private List<Album> albums = new List<Album>();
    
    public Autor(string nome)
    {
        Nome = nome;
        
    }
    public string Nome { get;  } = "";

    public void AdicionarAlbum (Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia de {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome}");
            album.ExibirMusicasAlbum();
        }
    }
}