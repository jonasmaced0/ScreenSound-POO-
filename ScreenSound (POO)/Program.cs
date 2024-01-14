//Banda metallica = new("Metallica");

//Album albumDoMetallica = new("Kill 'Em All");

//Musica musica1 = new(metallica, "Hit the Lights")
//{
//    Duracao = 257,
//    Disponibilidade = true,
//};

//Musica musica2 = new(metallica, "Jump in the Fire")
//{
//    Duracao = 258,
//    Disponibilidade = false,
//};


//albumDoMetallica.AdicionarMusica(musica1);
//albumDoMetallica.AdicionarMusica(musica2);
//metallica.AdicionarAlbum(albumDoMetallica);


//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//Console.WriteLine("\n");
//albumDoMetallica.ExibirMusicasDoAlbum();
//Console.WriteLine("\n");
//metallica.ExibirDiscografia();


Episodio episidio1 = new(3, "Técnicas de facilitação", 45);
episidio1.AdicionarConvidados("Maria");
episidio1.AdicionarConvidados("Marcelo");

Episodio episidio2 = new(1, "Técnicas de programação", 54);
episidio2.AdicionarConvidados("João");
episidio2.AdicionarConvidados("José");

Episodio episidio3 = new(2, "Técnicas de aprendizado", 69);
episidio3.AdicionarConvidados("Pedro");
episidio3.AdicionarConvidados("Pablo");


Podcast podcast = new("Malabarizando o conhecimento", "Macedo");

podcast.AdicionarEpisodio(episidio1);
podcast.AdicionarEpisodio(episidio2);
podcast.AdicionarEpisodio(episidio3);

podcast.ExibirDetalhes();


