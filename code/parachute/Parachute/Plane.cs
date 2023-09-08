using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    internal class Plane
    {
        public const int planeLength = 29;                                      //Longueur de l'avion
        public const int planeHeight = 6;                                       //Hauteur de l'avion
        public int x = 0;                                                       //Valeur x de l'avion
        public int y = 0;                                                       //Valeur y de l'avion
        public List<Para> insideplane = new List<Para>();                       //Créer une collection de parachutiste dans l'avion
        
        public string[] view =                                                  //Sprite de l'avion
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        /// <summary>
        /// Rajoute les parachutistes dans l'avion
        /// </summary>
        /// <param name="nbr"></param>
        public void addParachutist(int nbr)
        {
            for (int p = 0; p < nbr; p++)
            insideplane.Add(new Para("Bob"+p.ToString()));
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Plane()
        {
            
        }
        /// <summary>
        /// Modifie les valeurs de l'avion
        /// </summary>
        public void update()
        {
            if (x == Console.WindowWidth -1)
            {
                x = 0;
                addParachutist(1);
            }
            else
            {
                ++x;
            }
        }

        /// <summary>
        /// Dessine l'avion
        /// </summary>
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

        /// <summary>
        ///Enlève un parachutiste de l'avion 
        /// </summary>
        public void parajump()
        {
            insideplane.RemoveAt(0);    //retirer un parachutist de l'avion
        }
    }
}
