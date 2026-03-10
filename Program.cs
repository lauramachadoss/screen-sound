Album albumHarry = new Album();
albumHarry.Nome = "Harry`s House";

Musica musica1 = new Musica();
musica1.Nome = "Matilda";
musica1.Duração = 245;

Musica musica2 = new Musica();
musica2.Nome = "As It Was";
musica2.Duração = 166;

Musica musica3 = new Musica();
musica3.Nome = "Little Freak";
musica3.Duração = 201;

albumHarry.AdicionarMusica(musica1);
albumHarry.AdicionarMusica(musica2);
albumHarry.AdicionarMusica(musica3);

albumHarry.ExibirDiscografia();