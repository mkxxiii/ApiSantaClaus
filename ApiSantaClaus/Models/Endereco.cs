﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSantaClaus.Models
{
    public class Endereco
    {
        public string Estado { get; set; }
        
        public string Cidade { get; set; }
        
        public string Numero { get; set; }
        
        public string Bairro { get; set; }
        
        public string Rua { get; set; }
    }
}
