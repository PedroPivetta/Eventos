using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.api.Models;

namespace ProEventos.api.Controllers
{
    [Route("api/[controller]")]
    public class EventoController : Controller
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
                new Evento(){
                EventoId = 1,
                Tema = "Angular 11 3 .net 5",
                Local = "Taquaritinga",
                Lote = "Primeriro lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL =  "Imagem1",
                },

                new Evento(){
                EventoId = 1,
                Tema = "Angular 11 3 .net 5",
                Local = "Taquaritinga",
                Lote = "Segundo lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(3).ToString(),
                ImagemURL =  "Imagem2",
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

        [HttpGet("id")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
        
        }
    }
