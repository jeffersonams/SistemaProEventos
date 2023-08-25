using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {

            new Evento()
            {
            EventoId = 1,
            Tema = "Angular 11 e .Net5",
            Local = "São Paulo",
            Lote = "1 Lote",
            QtdePessoas = 1,
            DataEvento = DateTime.Now.AddDays(2).ToString()
            },
            new Evento()
            {
            EventoId = 2,
            Tema = "O melhor de Angular 11 e .Net5",
            Local = "São Paulo",
            Lote = "2 Lote",
            QtdePessoas = 1,
            DataEvento = DateTime.Now.AddDays(3).ToString()
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
        public IEnumerable<Evento>GetbyId(int id)
        {

             return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPut("{id}")]
        public string Atualizar(string id)
        {
             return "Arquivo deletado com sucesso";
        }


    }
}
