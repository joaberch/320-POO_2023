using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    internal class Para
    {
        public string[] withoutParachute =                  //Sprite du parachutiste sans parachute
{
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
     };
        private string[] withParachute =                    //Sprite du parachutiste avec un parachute
     {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
     };

        public int x;                                       //Valeur x du parachutiste (left)
        public int y = 0;                                   //valeur y du parachutiste (up)
        public bool havePara = false;                       //Vérifie si le parachutiste doit mettre son parachute

        /// <summary>
        /// Dessine le parachute
        /// </summary>
        public void draw()
        {
            for (int z = 0; z != 6; ++z)
            {
                Console.SetCursorPosition(this.x, z + y);

                if (y != 26)
                {
                    string[] view = havePara ? withParachute : withoutParachute;
                    Console.WriteLine(view[z]);
                }
                else
                {
                    Console.WriteLine(withoutParachute[z]);
                }
            }
        }

        /// <summary>
        /// Modifie la valeur du parachutiste
        /// </summary>
        public void Update()
        {
            if (this.y <= 25) //arrêter de descendre
            {
                ++y;
            }
            if (this.y >= 15)
            {
                havePara = true;
            }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name"></param>
        public Para(string name)
        {

        }
    }
}
