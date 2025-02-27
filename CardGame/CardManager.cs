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

        public static bool RightCardWins(Card card1, Card card2)
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

        public static Card GetCard()
        {
            Card card = deck.Last();
            deck.Remove(card);
            return card;
        }

        public static void CreateDeck()
        {
            deck.Clear();
            foreach (var suit in Global.suits)
            {
                for (int i = 6; i <= 7;  i++)
                {
                    deck.Add(new() { rank = i, suit = suit });
                }
            }
            Shuffle();
            strongSuit = deck.Last().suit;
        }

        public static void Shuffle()
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