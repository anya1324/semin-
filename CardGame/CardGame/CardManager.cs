using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class CardManager
    {
        public static string strongSuit;
        public static List<Card> deck = new List<Card>();
        public static List<Card> cardsOnField = new List<Card>();

        public static bool RightCardWins(Card card1, Card card2) //kontroluje, jestli 2. karta může být dáná na 1.
        {
            if (card1.suit == card2.suit && card2.rank > card1.rank)
            {
                return true;
            }
            if (card1.suit != strongSuit && card2.suit == strongSuit)
            {
                return true;
            }
            return false;
        }

        public static Card GetCard() //bere kartu z balíčku karet
        {
            Card card = deck.Last();
            deck.Remove(card);
            return card;
        }

        public static void CreateDeck() // tvorba 32 karet
        {
            deck.Clear();
            foreach (var suit in Global.suits)
            {
                for (int i = Global.minCard; i <= Global.maxCard;  i++) // karty od 6 do A
                {
                    deck.Add(new() { rank = i, suit = suit });
                }
            }
            Shuffle(); 
            strongSuit = deck[0].suit;
        }

        public static void Shuffle() // mixuje karty
        {
            Random rnd = new Random();

            for (int i = deck.Count - 1; i > 0; i--)
            {
                int num = rnd.Next(0, i + 1);
                Card temp = deck[i];
                deck[i] = deck[num];
                deck[num] = temp;
            }
        }
    }
}