using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSantaClaus.Models
{
    public class Carta
    {
        public string NomeCrianca { get; set; }

        public Endereco Endereco { get; set; }
        
        public int Idade { get; set; }
        
        public string TextoCarta { get; set; }

    }
}
