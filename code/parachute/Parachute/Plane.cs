using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    internal class Plane
    {
        const int planeLength = 29;             //Longueur de l'avion
        const int planeHeight = 6;              //Hauteur de l'avion
        int x = 0;                              //Valeur x de l'avion
        int y = 0;                              //Valeur y de l'avion
        List<Para> club = new List<Para>();     //Créer une collection de parachutier
        public string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public Plane()      //Constructeur
        {
            //Para Bob = new Para();
            //Para Alice = new Para();
            //Para Max = new Para();
            //Para[] para = new Para[1];
            //List<Para> club = new List<Para>();
        }

        public void update()
        {
            ++x;
        }

        public void draw()
        {
            for (int i = 0; i != planeHeight; ++i)
            {
                Console.SetCursorPosition(x, y);
                ++y;
                Console.WriteLine(view[i]);
            }
            y = 0;
        }
    }
}
