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
        private string[] withoutParachute =
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
        public void Parashow()
        {
            for (int z = 0; z != 6; ++z)
            {
                Console.SetCursorPosition(this.x, z + compteur);

                Console.WriteLine(withoutParachute[z]);
            }
        }

        public void Update()
        {
            if (this.compteur != 25) //arrêter de descendre
            {
                ++compteur;
            }

        }
        public Para(string name)    //Constructeur
        {

        }
    }
}
