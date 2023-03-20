using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    internal class Lampada
    {
        private string estadoLampada;

        public Lampada() 
        {
            estadoLampada = "Apagado";
        }

        public void acende()
        {
            estadoLampada = "Aceso";
        }
        public void apaga()
        {
            estadoLampada = "Apagado";
        }

        public  void mostraEstado()
        {
            if(estadoLampada == "Aceso")
            {
                Console.WriteLine("Lampada acesa!");
            }
            else
            {
                Console.WriteLine("Lampada Apagada");
            }
        }
    }
}
