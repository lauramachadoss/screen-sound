Autor harrystyles = new Autor("Harry Styles");

Album albumHarry = new Album("Harry`s House");

Musica musica1 = new(harrystyles, "Matilda") { Duração = 245 };

Musica musica2 = new(harrystyles, "As It Was") { Duração = 166 };

Musica musica3 = new(harrystyles, "Little Freak") { Duração = 201, };

albumHarry.AdicionarMusica(musica1);
albumHarry.AdicionarMusica(musica2);
albumHarry.AdicionarMusica(musica3);

harrystyles.AdicionarAlbum(albumHarry);
harrystyles.ExibirDiscografia();
Console.WriteLine("\n");

Host laumachado = new Host("Laura Mchado");

Podcast crisesja = new Podcast("Crises de uma recém Jovem Adulta!\n", laumachado);

Episodio ep1 = new(1, "Vida pos Ensino Médio", 52);
ep1.AdicionarConvidado("Clara Rodrigues");

Episodio ep2 = new(2, "Surpresa: sou a Responsabilidade", 78);
ep2.AdicionarConvidado("Ana Júlia Garcia");






