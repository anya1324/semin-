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
        public List<Card> cards = new List<Card>(); //přesné karty, co má hráč nebo bot aktuálně ve "ruce"

        public void PlayCard(int index) 
        {
            if (cards.Count == 1 && CardManager.deck.Count == 0) //kontroluje konec hry
            {
                App.gameEnd = true;
                return;
            }
            CardManager.cardsOnField.Add(cards[index]);
            cards[index].Print(); //vypisuje kartu, co dávám
            cards.RemoveAt(index); //vypisuje kartu, co dávám pryč
        }

        public void GetHand() //bere karty, jestli je jich méně než 6
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

        public virtual void Play() { } // základ pro způsob hraní hráče i bota
    }
}