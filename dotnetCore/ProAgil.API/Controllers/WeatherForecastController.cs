﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.API.Model;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[]{
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular e .Net Core",
                    Local = "Jundiaí",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Angular e suas novidades",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                }
            };
        }

        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[]{
                    new Evento() {
                        EventoId = 1,
                        Tema = "Angular e .Net Core",
                        Local = "Jundiaí",
                        Lote = "1º Lote",
                        QtdPessoas = 250,
                        DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                    },
                    new Evento() {
                        EventoId = 2,
                        Tema = "Angular e suas novidades",
                        Local = "São Paulo",
                        Lote = "2º Lote",
                        QtdPessoas = 350,
                        DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                    }
                }.FirstOrDefault(x => x.EventoId == id);
        }
    }

    
}
