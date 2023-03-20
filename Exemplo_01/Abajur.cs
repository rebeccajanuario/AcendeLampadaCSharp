using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    internal class Abajur
    {
        private Lampada bocal;

        public Abajur() 
        {
            bocal = null;
        }

        public void encaixaLampada(Lampada lampada) 
        {
            bocal = lampada;
        }

        public void liga()
        {
            bocal.acende();
        }
    }
}
