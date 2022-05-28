using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventosController : ControllerBase
{
  
    private readonly DataContext _context;
    public EventosController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.eventos;
    }
    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _context.eventos.Where(evento => evento.EventoId == id);
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
