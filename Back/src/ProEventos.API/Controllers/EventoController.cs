using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using ProEventos.API.Data;
using ProEventos.API.models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    private readonly DataContext context;

    public EventoController(DataContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return context.Eventos;
    }

    [HttpGet("id")]
    public IEnumerable<Evento> GetById(int id)
    {
        return context.Eventos.Where(evento => evento.EventoId == id);
    }

    


}
