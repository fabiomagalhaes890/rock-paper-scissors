using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class Torneio
  {
    public Jogador Campeao { get; set; }
    public List<Partida> Partidas { get; set; }

    public Torneio()
    {
        Campeao = new Jogador();
        Partidas = new List<Partida>();
    }
  }
}
