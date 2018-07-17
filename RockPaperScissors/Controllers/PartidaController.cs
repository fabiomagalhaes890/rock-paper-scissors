using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
  [Route("api/[controller]")]
  public class PartidaController : ControllerBase
  {
    private Partida _partida;

    public PartidaController()
    {
      _partida = new Partida();
    }

    [HttpPost]
    [Route("/informar-jogador")]
    public IActionResult InformarJogador([FromBody]Jogador jogador)
    {
      _partida.Jogadores.Add(jogador);
      return Ok(_partida);
    }

    [HttpGet]
    public IActionResult CarregarJogadores()
    {
      return Ok(_partida.Jogadores);
    }

    [HttpPost]
    [Route("/iniciar-partida")]
    public IActionResult IniciarPartida()
    {
      return Ok(_partida.Jogadores);
    }
  }
}
