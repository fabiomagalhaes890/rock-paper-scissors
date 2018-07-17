using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class Partida
  {
    public Jogador Vencedor { get; set; }
    public List<Jogador> Jogadores { get; set; }

    public Partida()
    {
        Vencedor = new Jogador();
        Jogadores = new List<Jogador>();
    }
  }
}
