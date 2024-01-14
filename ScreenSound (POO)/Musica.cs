
class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string? Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponibilidade {  get; set; }
    public string DescricaoResumida => $"A música {Nome} pertece a banda {Artista} e tem {Duracao} de segundos de duração";

  
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}.");
        Console.WriteLine($"Artista: {Artista.Nome}.");
        Console.WriteLine($"Duração: {Duracao} segundos.");
        if ( Disponibilidade == true )
        {
            Console.WriteLine($"A música {Nome} está disponível no plano.");
        } else
        {
            Console.WriteLine($"A música {Nome} não está disponível no plano atual, adquira o plano Plus+.");
        }
    }


}



