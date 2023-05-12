using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proev.API.Data;
using Proev.API.Models;

namespace Proev.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {  
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {  
            return _context.Eventos;
        }

        [HttpGet("id")]
        public Evento GetById(int id)
        {  
            return _context.Eventos.FirstOrDefault(
                evento => evento.EventoID == id
            );
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
