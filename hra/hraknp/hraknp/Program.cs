using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hraknp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random(); //generování random čísel
            int userScore = 0;
            int pcScore = 0;

            int scoreToWin = 3;

            while (userScore < scoreToWin && pcScore < scoreToWin)
            {
                Console.WriteLine("Zadej jednu z akci (kamen, nuzky, papir)");
                string userInput = Console.ReadLine();

                int userNumInput = -1;

                if (userInput == "kamen") //userInput.Equals je vice korektnejsi pouzit
                {
                    userNumInput = 0;
                }

                else if (userInput == "nuzky")
                {
                    userNumInput = 1;
                }

                else if (userInput == "papir")
                {
                    userNumInput = 2;
                }

                else
                {
                    Console.WriteLine("Neznamy vstup");
                }

                int pcInput = rng.Next();


                if (userNumInput == pcInput) //remiza
                {
                    Console.WriteLine("remiza");
                }
                else if (
                    (userNumInput == 1 && pcInput == 0) // n proti k
                    || (userNumInput == 2 && pcInput == 1) // p proti n
                    || (userNumInput == 0 && pcInput == 2)) // k proti p
                   //prohra
                {
                    Console.WriteLine("Prohral jsi");
                    pcScore++;
                }
                else // vyhra
                {
                    Console.WriteLine("Vyhral jsi");
                    userScore++;
                }
                Console.WriteLine("Aktualni skore: \nHrac:" + userScore + "\nPocitac:" + pcScore);
            }
            Console.WriteLine(); //aby se nam to hnedka neukoncilo
        }
    }
}
