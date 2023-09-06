using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    internal class Plane
    {
        const int planeLength = 29;     //Longueur de l'avion
        const int planeHeight = 6;      //Hauteur de l'avion
        int x = 0;                      //Valeur x de l'avion
        int y = 0;                      //Valeur y de l'avion
        public string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public void update()
        {
            Console.MoveBufferArea(x, y, planeLength, planeHeight, ++x, y);
        }

        public void draw()
        {
            for (int i = 0; i != planeHeight; ++i)
            {
                Console.WriteLine(view[i]);
            }
        }
    }
}
