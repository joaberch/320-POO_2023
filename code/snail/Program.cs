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
            const int intVITESSE = 150;
            int hauteur = 0;
            bool reset = false;
            int intnbrboucle;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorVisible = false;

            //Afficher l'escargot
            do
            {
                //permet au programme de recommencer
                intnbrboucle = 0;
                Console.Clear();

                Console.Write(strESCARGOT);

                while (intnbrboucle != intvieescargot)
                {
                    //Console.SetCursorPosition(intnbrboucle, hauteur);
                    Console.MoveBufferArea(intnbrboucle, hauteur, 4, 1, intnbrboucle + 1, hauteur);
                    Thread.Sleep(intVITESSE);
                    ++intnbrboucle;
                }

                //Si escargot meurt
                Console.Clear();
                Console.SetCursorPosition(intvieescargot, hauteur);
                Console.Write("____");
                Console.ReadKey();
                reset = true;
                intvieescargot+=5;
            }
            while (reset);
        }
    }
}
