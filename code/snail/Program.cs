//Caractéristique de l'escargot (vie, vitesse, position)

//Afficher l'escargot

//Déplacer l'escargot

//Si escargot meurt

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Caractéristique de l'escargot (vie, vitesse, position)
            const string strESCARGOT = "_@_ö";
            int intvieescargot = 5;
            const int intVITESSE = 300;
            int hauteur = 5;
            bool reset = false;
            Console.ForegroundColor = ConsoleColor.Red;

            //Afficher l'escargot
            do
            {
                for (int i = 0; i <= intvieescargot; i++)
                {
                    Console.Clear();
                    Console.SetCursorPosition(i, hauteur);
                    Console.Write(strESCARGOT);
                    Thread.Sleep(intVITESSE);
                }

                //Si escargot meurt
                Console.Clear();
                Console.SetCursorPosition(intvieescargot, hauteur);
                Console.Write("____");
                Console.Read();
                reset = true;
            }
            while (!reset);
        }
    }
}
