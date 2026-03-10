Album albumHarry = new Album();
albumHarry.Nome = "Harry`s House";

Musica musica1 = new Musica();
musica1.Nome = "Matilda";

Musica musica2 = new Musica();
musica2.Nome = "As It Was";

Musica musica3 = new Musica();
musica3.Nome = "Little Freak";

albumHarry.AdicionarMusica(musica1);
albumHarry.AdicionarMusica(musica2);
albumHarry.AdicionarMusica(musica3);

albumHarry.ExibirDiscografia();