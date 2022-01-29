using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]
            {
            new Evento(){
            EventoId = 1,
            Tema = "Angular 11 e .net",
            Local = "Uberlandia",
            Lote = "1",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "Foto.png"
            },
            new Evento(){
            EventoId = 2,
            Tema = "Angular 1 e .net",
            Local = "Uberlandia",
            Lote = "1",
            QtdPessoas = 850,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "Foto.png"
            } 
        };
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(i => i.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }


     
    }
}