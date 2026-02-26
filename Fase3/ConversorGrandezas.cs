using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3
{
    public class ConversorGrandezas
    {
        private readonly IConversorGrandeza _conversor;

        public ConversorGrandezas(IConversorGrandeza conversor)
        {
            _conversor = conversor;
        }

        public string Converter(decimal valor)
        {
            var resultado = _conversor.Converter(valor);
            return $"{resultado} {_conversor.ObterSimbolo()}";
        }
    }
}
