using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class CardDeck
    {
        public List<Card> DeckOfCards { get; set; }


        public CardDeck()
        {
            //Create the list of cards that make up the deck
            //The deck will not have any jokers
            this.DeckOfCards = new List<Card>();
            
            string cardSuite = "Spades";

            for (int i = 1; i <= 13; i++)
            {
                this.DeckOfCards.Add( new Card() { Value=i, Name=getCardName(i), Suite=cardSuite});
            }

            cardSuite = "Hearts";
            for (int i = 1; i <= 13; i++)
            {
                this.DeckOfCards.Add(new Card() { Value = i, Name = getCardName(i), Suite = cardSuite });
            }

            cardSuite = "Clubs";
            for (int i = 1; i <= 13; i++)
            {
                this.DeckOfCards.Add(new Card() { Value = i, Name = getCardName(i), Suite = cardSuite });
            }

            cardSuite = "Diamonds";
            for (int i = 1; i <= 13; i++)
            {
                this.DeckOfCards.Add(new Card() { Value = i, Name = getCardName(i), Suite = cardSuite });
            }
        }

        internal int CountCardsInDeck()
        {
            return DeckOfCards.Count();
        }

        public Card DealCard()
        {
            Card cardBeingDealt = DeckOfCards.ElementAt(0);
            DeckOfCards.Remove(DeckOfCards.ElementAt(0));

            return cardBeingDealt;
        

        }

        private string getCardName(int cardValue)
        {
            string cardName = "";

            switch (cardValue)
            {
                case 1:
                    cardName = "Ace";
                    break;
                case 2:
                    cardName = "Two";
                    break;
                case 3:
                    cardName = "Three";
                    break;
                case 4:
                    cardName = "Four";
                    break;
                case 5:
                    cardName = "Five";
                    break;
                case 6:
                    cardName = "Six";
                    break;
                case 7:
                    cardName = "Seven";
                    break;
                case 8:
                    cardName = "Eight";
                    break;
                case 9:
                    cardName = "Nine";
                    break;
                case 10:
                    cardName = "Ten";
                    break;
                case 11:
                    cardName = "Jack";
                    break;
                case 12:
                    cardName = "Queen";
                    break;
                case 13:
                    cardName = "King";
                    break;
                default:
                    cardName = "";
                    break;
            }

            return cardName;

        }


        public void ShuffleCards()
        {
            List<Card> tempDeck = new List<Card>();
            Random randomGenerator = new Random();
            int cardToMove = 0;
            while(DeckOfCards.Count > 0)
            {
                cardToMove = randomGenerator.Next(0, DeckOfCards.Count);
                tempDeck.Add(DeckOfCards.ElementAt(cardToMove));
                DeckOfCards.Remove(DeckOfCards.ElementAt(cardToMove));
            }
            while (tempDeck.Count > 0)
            {
                cardToMove = randomGenerator.Next(0, tempDeck.Count);
                DeckOfCards.Add(tempDeck.ElementAt(cardToMove));
                tempDeck.Remove(tempDeck.ElementAt(cardToMove));
            }
        }

        public string DisplayDeck()
        {
            string outputString = "";
            foreach (var card in DeckOfCards)
            {
                outputString += string.Format("{0} of {1}<br />", card.Name, card.Suite);
            }
            return outputString;
        }


    }

}