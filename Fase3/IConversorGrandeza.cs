using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3
{


    public interface IConversorGrandeza
    {
        decimal Converter(decimal valor);
        string ObterSimbolo();
    }
}

