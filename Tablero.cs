using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_serpiente
{
    public class Tablero
    {
        public readonly int Altura;
        public readonly int Anchura;
        public bool ContieneCaramelo;

        public Tablero(int altura, int anchura)
        {
            Altura = altura;
            Anchura = anchura;
            ContieneCaramelo = false;
        }

        public void DibujaTablero()
        {
            for (int i = 0; i <= Altura; i++)
            {
                Util.DibujaPosicion(Anchura, i, "#");
                Util.DibujaPosicion(0, i, "#"); 
            }
            for (int i = 0; i <= Anchura; i++)
            {
                Util.DibujaPosicion(i, 0, "#");
                Util.DibujaPosicion(i, Altura, "#");
            }
        }
    }
}
