🎵 Screen Sound

Projeto desenvolvido em C# com foco em Programação Orientada a Objetos, durante o curso da Alura.

📌 Sobre o projeto

O Screen Sound é uma aplicação de console que simula o gerenciamento de músicas, álbuns e podcasts. O projeto foi desenvolvido com o objetivo de praticar conceitos fundamentais de lógica de programação e organização de código utilizando orientação a objetos.

🚀 Funcionalidades

Cadastro de autores/artistas

Criação de álbuns

Adição de músicas com duração

Exibição de discografia

Criação de podcasts

Cadastro de episódios

Inclusão de convidados nos episódios

🛠️ Tecnologias utilizadas

C#

.NET

Programação Orientada a Objetos (POO)

💻 Exemplo de uso
Autor harrystyles = new Autor("Harry Styles");

Album albumHarry = new Album("Harry`s House");

Musica musica1 = new(harrystyles, "Matilda") { Duração = 245 };
Musica musica2 = new(harrystyles, "As It Was") { Duração = 166 };
Musica musica3 = new(harrystyles, "Little Freak") { Duração = 201 };

albumHarry.AdicionarMusica(musica1);
albumHarry.AdicionarMusica(musica2);
albumHarry.AdicionarMusica(musica3);

harrystyles.AdicionarAlbum(albumHarry);
harrystyles.ExibirDiscografia();

Host laumachado = new Host("Laura Machado");

Podcast crisesja = new Podcast("Crises de uma recém Jovem Adulta!", laumachado);

Episodio ep1 = new(1, "Vida pós Ensino Médio", 52);
ep1.AdicionarConvidado("Clara Rodrigues");
📚 Aprendizados

Durante o desenvolvimento deste projeto, pratiquei:

Estruturação de classes e objetos

Encapsulamento

Organização de código

Relacionamento entre entidades

Boas práticas de programação

🎯 Objetivo

Consolidar conhecimentos em C# e POO, criando uma base sólida para projetos mais complexos no futuro.
