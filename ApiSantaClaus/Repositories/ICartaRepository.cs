using ApiSantaClaus.Models;
using System.Collections.Generic;

namespace ApiSantaClaus.Repositories
{
    public interface ICartaRepository
    {
        public IList<Carta> GetListaCartaPorCidade(string cidade);

        public void InserirCarta(Carta carta);
    }
}
