using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class User : Player
    {
        public int index = 0;
        bool picking;

        public override void Play()
        {
            picking = true;
            while (picking)
            {
                Console.SetCursorPosition(0, 3);
                PrintCards();
                Input();
            }
        }

        public void Input() // vnější vstup hráče
        {
            var input = Console.ReadKey();

            if (input.Key == ConsoleKey.DownArrow && index + 1 < cards.Count)
            {
                index++;
            }
            else if (input.Key == ConsoleKey.UpArrow && index > 0)
            {
                index--;
            }
            else if (input.Key == ConsoleKey.LeftArrow && CardManager.cardsOnField.Count > 0)
            {
                if (CardManager.cardsOnField.Count % 2 == 1)
                {
                    foreach (var item in CardManager.cardsOnField)
                    {
                        cards.Add(item);
                    }
                }
                App.roundEnd = true;
                picking = false;
            }
            else if (input.Key == ConsoleKey.RightArrow)
            {
                if (CardManager.cardsOnField.Count % 2 == 0)
                {
                    PlayCard(index);
                    picking = false;
                }
                else if (CardManager.RightCardWins(CardManager.cardsOnField.Last(), cards[index]))
                {
                    PlayCard(index);
                    picking = false;
                }
            }
        }

        public override void PrintCards() //píše moje karty, jaké mám
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    cards[i].Print();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    cards[i].Print();
                }
            }
            Console.WriteLine("                            ");
        }
    }
}