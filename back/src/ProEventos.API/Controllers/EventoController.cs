using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[] {
        new Evento{
            EventoId = 1,
            Tema = "Angular 12 e .NET 6",
            Local = "Curitiba",
            Lole = "1º",
            QtePessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "Foto.png"
        },
          new Evento {
            EventoId = 2,
            Tema = "Angular 12 e .NET 6 + sqlServer",
            Local = "São Pulo",
            Lole = "2º",
            QtePessoas = 500,
            DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"),
            ImagemURL = "Foto.png"
        }
    };
    public EventoController()
    {
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }
    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }
    [HttpPost]
    public string Post()
    {
        return "exemplo post";
    }
    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"exemplo put {id}";
    }
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"exemplo Delete {id}";
    }


}
