using System.Collections.Generic;
using ApiSantaClaus.Models;
using System.Linq;

namespace ApiSantaClaus.Repositories
{
    public class CartaRepository : ICartaRepository
    {
        public CartaRepository()
        {
            db = new List<Carta>();
        }
        private static List<Carta> db { get; set; }

        public IList<Carta> GetListaCartaPorCidade(string cidade)
        {
            string cidadeTratada = cidade.ToUpper().Trim();

            return db.Where(a => a.Endereco.Cidade.ToUpper().Trim() == cidadeTratada).ToList();
        }

        public void InserirCarta(Carta carta)
        {
            db.Add(carta);
        }
    }
}
