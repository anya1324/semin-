using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Bot : Player
    {
        public override void Play()
        {
            if (CardManager.cardsOnField.Count > 0)
            {
                Responce();
            }
            else
            {
                PlayCard(new Random().Next(0, cards.Count));
            }
        }

        public void Responce()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (CardManager.RightCardWins(CardManager.cardsOnField.Last(), cards[i]))
                {
                    PlayCard(i);
                    return;
                }
            }
            foreach (var item in CardManager.cardsOnField)
            {
                cards.Add(item);
            }
            App.roundEnd = true;
        }
    }
}