using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Bot : Player
    {
        public override void Play() //logika, jak a kdo bude hrát
        {
            if (CardManager.cardsOnField.Count % 2 == 1)
            {
                Responce();
            }
            else if (CardManager.cardsOnField.Count == 0)
            {
                PlayCard(new Random().Next(0, cards.Count));
            }
            else
            {
                if (new Random().Next(0, 2) == 0)
                {
                    PlayCard(new Random().Next(0, cards.Count));
                }
                else
                {
                    App.roundEnd = true;
                }
            }
        }

        public void Responce() // bot přemýšlí jak bude hrát
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (CardManager.RightCardWins(CardManager.cardsOnField.Last(), cards[i]))
                {
                    PlayCard(i);
                    return;
                }
            }
            foreach (Card item in CardManager.cardsOnField)
            {
                cards.Add(item);
            }
            App.roundEnd = true;
        }
    }
}