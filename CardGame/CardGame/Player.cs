using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Player
    {
        public List<Card> cards = new List<Card>();

        public void PlayCard(int index)
        {
            if (cards.Count == 1 && CardManager.deck.Count == 0)
            {
                App.gameEnd = true;
                return;
            }
            CardManager.cardsOnField.Add(cards[index]);
            cards[index].Print();
            cards.RemoveAt(index);
        }

        public void GetHand()
        {
            for (int i = cards.Count; i < 6; i++)
            {
                if (CardManager.deck.Count == 0)
                {
                    return;
                }
                cards.Add(CardManager.GetCard());
            }
        }

        public virtual void PrintCards()
        {
            foreach (Card card in cards)
            {
                card.Print();
            }
        }

        public virtual void Play() { }
    }
}