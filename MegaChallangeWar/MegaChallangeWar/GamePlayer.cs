using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class GamePlayer
    {
        public Queue<Card> CardHand { get; set; }

        public GamePlayer()
        {
            CardHand = new Queue<Card>();
        }

        internal void ReceiveCard(Card tempCard)
        {
            CardHand.Enqueue(tempCard);
        }

        public Card PlayCard()
        {
            return CardHand.Dequeue();
        }

    }
}