using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSantaClaus.Models
{
    public class ErrorMessage
    {
        public string msgErro { get; set; }

        public ErrorMessage (string msg)
        {
            msgErro = msg;
        }
    }
}
