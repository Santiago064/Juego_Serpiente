using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_serpiente
{
    class Util
    {
        public static void DibujaPosicion(int x, int y, string caracter)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(caracter);
        }
    }
}
