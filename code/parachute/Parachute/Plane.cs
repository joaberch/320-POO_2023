using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    internal class Plane
    {
        public const int planeLength = 29;                                     //Longueur de l'avion
        public const int planeHeight = 6;                                      //Hauteur de l'avion
        public int x = 0;                                               //Valeur x de l'avion
        public int y = 0;                                               //Valeur y de l'avion
        public List<Para> insideplane = new List<Para>();               //Créer une collection de parachutiste dans l'avion
        
        public string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public void addParachutist(int nbr)
        {
            for (int p = 0; p < nbr; p++)
            insideplane.Add(new Para("Bob"+p.ToString()));
        }
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

        public void parajump()
        {
            insideplane.RemoveAt(0);    //retirer un parachutist de l'avion
        }
    }
}
