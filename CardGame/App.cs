using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class App
    {
        public static bool roundEnd = false;
        public static bool gameEnd = false;

        Bot bot = new Bot();
        User user = new User();
        Player current = new Player();
        bool userPlaying = true;

        public App()
        {
            Console.CursorVisible = false;
            CardManager.CreateDeck();
            current = user;

            while (!gameEnd)
            {
                Round();
            }

            Console.Clear();
            if (user.cards.Count > 0)
            {
                Console.WriteLine("You win!");
                Console.WriteLine("bots remaining cards:");
                foreach (Card card in bot.cards)
                {
                    card.Print();
                }
            }
            else
            {
                Console.WriteLine("You lost!");
                Console.WriteLine("your remaining cards:");
                foreach (Card card in user.cards)
                {
                    card.Print();
                }
            }
        }
        public void Round()
        {
            bot.GetHand();
            user.GetHand();

            WriteHeader();

            roundEnd = false;
            while (!gameEnd && !roundEnd && current.cards.Count != 0)
            {
                WriteHeader();
                current.Play();
                ChangeCurrent();
            }
            CardManager.cardsOnField.Clear();
        }

        public void ChangeCurrent()
        {
            userPlaying = !userPlaying;
            if (userPlaying)
            {
                current = user;
            }
            else
            {
                current = bot;
            }
        }

        public void WriteHeader()
        {
            Console.Clear();

            Console.WriteLine("Strong suit: " + CardManager.strongSuit + " | Cards remaining: " + CardManager.deck.Count + " ");
            Console.WriteLine("Bots cards: " + bot.cards.Count + "                           playfield:");
            Console.WriteLine("---------------------------------------------------");

            int addLine = 0;
            for (int i = 0; i < CardManager.cardsOnField.Count; i++)
            {
                Console.SetCursorPosition(40, i + addLine + 3);
                CardManager.cardsOnField[i].Print();
                if (i % 2 == 1)
                {
                    addLine++;
                    Console.SetCursorPosition(40, i + addLine + 3);
                    Console.WriteLine("---------------");
                }
            }
        }
    }
}