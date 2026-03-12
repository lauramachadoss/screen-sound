class Musica
{
    public Musica(Autor artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; } 
    public Autor Artista { get; } 
    public int Duração { get; set;}
    public bool Disponivel { get; set;}
    public string DescricaoResumida => $"A música {Nome} pertence à {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duração}");
    }
}
