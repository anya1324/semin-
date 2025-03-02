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
            Console.CursorVisible = false; //aby nebyl vidět kurzor
            CardManager.CreateDeck();
            current = user;

            while (!gameEnd) // hra bude pokračovat, dokud nebude nová karta
            {
                Round();
            }

            Console.Clear();
            if (user.cards.Count > 0) //kontroluje, kdo vyhrál
            {
                Console.WriteLine("You won!");
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
        public void Round() //kolo
        {
            bot.GetHand(); 
            user.GetHand();

            WriteHeader(); //píše počet karet bota

            roundEnd = false;
            while (!gameEnd && !roundEnd && current.cards.Count != 0) //když probíhá kolo
            {
                WriteHeader();
                current.Play();
                ChangeCurrent();
            }
            CardManager.cardsOnField.Clear(); //maže karty, které byly v tomto kole už odehrané
        }

        public void ChangeCurrent() //mění se z bota na hráče a naopak
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

        public void WriteHeader() //popis hry pro hráče
        {
            Console.Clear();

            Console.WriteLine("Strong suit: " + CardManager.strongSuit + " | Cards remaining: " + CardManager.deck.Count + " | Play with arrows on your keyboard, place the card - right, collect the card or end the round - left");
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