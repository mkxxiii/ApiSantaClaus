using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ApiSantaClaus.Models;
using ApiSantaClaus.Repositories;
using ApiSantaClaus.Services;

namespace ApiSantaClaus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SantaController : ControllerBase
    {
        private static readonly ICartaRepository repository = new CartaRepository();

        [HttpGet]
        public ResponseAdapter BuscarCartas(string cidade)
        {
            var response = CartaService.RegraBuscaCarta(cidade);
            if(response.isSucess)
                response.returnBody = repository.GetListaCartaPorCidade(cidade) as List<Carta>;
            
            return response;
        }

        [HttpPost]
        public ResponseAdapter SalvarCarta(Carta carta)
        {
            var response = CartaService.RegraCarta(carta);

            if (response.isSucess)
            {
                repository.InserirCarta(carta);
                response.returnBody = true;
            }

            return response;
        }
    }
}
