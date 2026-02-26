using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3
{
    public class ConversorBilhoes : IConversorGrandeza
    {
        public decimal Converter(decimal valor)
        {
            return valor / 1_000_000_000m;
        }

        public string ObterSimbolo()
        {
            return "Bi";
        }
    }
}
