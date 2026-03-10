class Musica
{
    public string Nome { get; set;} = "";
    public string Artista { get; set;} = "";
    public int Duração { get; set;}
    public bool Disponivel { get; set;}
    public string DescricaoResumida => $"A música {Nome} pertence à {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duração}");
    }
}
