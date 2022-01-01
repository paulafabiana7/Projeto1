using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto1.API.Models;

namespace Projeto1.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> evento = new Evento[]{
                    new Evento(){
                    
                    EventoId=1,
                    Local= "Trindade",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    TemaEvento = "C# e .Net 5",
                    QtdPessoas = 260,
                    Lote = "1° Lote",
                    ImagemUrl = "imagem.png"
                    
                    },

                    new Evento(){
                    
                    EventoId=2,
                    Local= "São Paulo",
                    DataEvento = DateTime.Now.ToString("dd/MM/yyyy"),
                    TemaEvento = "C# e .Net 5",
                    QtdPessoas = 400,
                    Lote = "4° Lote",
                    ImagemUrl = "imagem.png"
                    }

        };


        public EventoController(ILogger<EventoController> logger)
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
                return evento;
        } 

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
                return evento.Where( x => x.EventoId == id);
        }

         [HttpDelete("{id}")]
        public string Put(int id)
        {
                return $"Exemplo de Delete com id: {id}";
        }
    }
}
