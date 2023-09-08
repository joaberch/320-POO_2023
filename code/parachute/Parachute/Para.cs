using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    internal class Para
    {
        public string[] withoutParachute =
{
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
     };
        private string[] withParachute =
     {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
     };

        public int x;
        public int compteur = 0;
        public bool middlescreen = false;
        public void Parashow()
        {
            for (int z = 0; z != 6; ++z)
            {
                Console.SetCursorPosition(this.x, z + compteur);

                if (compteur != 26)
                {
                    string[] view = middlescreen ? withParachute : withoutParachute;
                    Console.WriteLine(view[z]);
                }
                else
                {
                    Console.WriteLine(withoutParachute[z]);
                }
            }
        }

        public void Update()
        {
            if (this.compteur <= 25) //arrêter de descendre
            {
                ++compteur;
            }
            if (this.compteur >= 15)
            {
                middlescreen = true;
            }
        }
        public Para(string name)    //Constructeur
        {

        }
    }
}
