using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSantaClaus.Models
{
    public class ResponseAdapter
    {
        public bool isSucess { get; set; }
        
        public dynamic details { get; set; }

        public dynamic returnBody { get; set; }
    }
}
