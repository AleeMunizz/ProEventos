using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proev.API.Models;

namespace Proev.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoID = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Campos do Jordão",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageURL = "Foto.png"
            },
            new Evento() {
                EventoID = 2,
                Tema = "Angular 11 e Suas Novidades",
                Local = "Campos do Jordão",
                Lote = "2º Lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                ImageURL = "Foto2.png"
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
            return _evento.Where(evento => evento.EventoID == id);
        }

        [HttpPost]
        public String Post()
        
        {  
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public String Put(int id)
        
        {  
            return "Exemplo de Put = {id}";
        }
        [HttpDelete("{id}")]
        public String Delete(int id)
        
        {  
            return "Exemplo de Delete = {id}";
        }
    }
}
