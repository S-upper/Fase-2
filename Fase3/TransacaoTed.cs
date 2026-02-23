using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3
{
    internal class TransacaoTed
    {
        private int _valor;

        public override bool Validar() => _valor > 5000;
    }
}
