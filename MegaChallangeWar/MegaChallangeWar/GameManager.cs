using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class GameManager
    {
        public CardDeck GameCardsDeck { get; set; }
        public GamePlayer PlayerOne { get; set; }
        public GamePlayer PlayerTwo { get; set; }
        public string outputText { get; set; }

        public GameManager()
        {
            GameCardsDeck = new CardDeck();
            PlayerOne = new GamePlayer();
            PlayerTwo = new GamePlayer();

        }

        public void PlayGame()
        {
            this.outputText = "";

            //Shuffle the cards
            GameCardsDeck.ShuffleCards();
            GameCardsDeck.ShuffleCards();

            //Deal the cards to the players
            DealCards();

            //Perform 20 rounds of the game loop
            for (int i = 0; i < 20; i++)
            {
                PlayRound();
            }

            //Determine who won
            DetermineWinner();

            
        }

        private void DetermineWinner()
        {
            outputText += string.Format("Player 1   |   Player 2<br />");
            outputText += string.Format("&nbsp;&nbsp;{0}&nbsp;&nbsp;&nbsp;&nbsp;{1}<br /><br />",
                PlayerOne.CardHand.Count.ToString(),
                PlayerTwo.CardHand.Count.ToString());

            if(PlayerOne.CardHand.Count == PlayerTwo.CardHand.Count)
            {
                //Tie game
                outputText += "Tie Game!";
            }
            else if(PlayerOne.CardHand.Count > PlayerTwo.CardHand.Count)
            {
                //Player one wins
                outputText += "Player One Wins!";
            }
            else
            {
                outputText += "Player Two Wins!";
            }
        }

        private void PlayRound()
        {
            List<Card> playerOnePlayedCards = new List<Card>();
            List<Card> playerTwoPlayedCards = new List<Card>();

            if(comparePlayedCards(playerOnePlayedCards, playerTwoPlayedCards))
            {
                //Player one wins
                outputText += "Player One Wins the Round!<br />";
                playerWinsRound("one", playerOnePlayedCards, playerTwoPlayedCards);
            }
            else
            {
                //Player two wins
                outputText += "Player Two Wins the Round!<br />";
                playerWinsRound("two", playerOnePlayedCards, playerTwoPlayedCards);
            }
        }

        private void playerWinsRound(string v, List<Card> playerOnePlayedCards, List<Card> playerTwoPlayedCards)
        {
            if (v == "one")
            {
                //Player one won the round
                collectBounty(PlayerOne.CardHand, playerOnePlayedCards, playerTwoPlayedCards);

            }
            else if(v == "two")
            {
                //Player two won the round
                collectBounty(PlayerTwo.CardHand, playerOnePlayedCards, playerTwoPlayedCards);
            }
        }

        private void collectBounty(Queue<Card> cardHand, List<Card> playerOnePlayedCards, List<Card> playerTwoPlayedCards)
        {
            foreach (var card in playerOnePlayedCards)
            {
                cardHand.Enqueue(card);
            }
            foreach (var card in playerTwoPlayedCards)
            {
                cardHand.Enqueue(card);
            }
        }

        private bool comparePlayedCards(List<Card> playerOnePlayedCards, List<Card> playerTwoPlayedCards)
        {
            if(PlayerOne.CardHand.Count > 0 && PlayerTwo.CardHand.Count > 0)
            {
                playerOnePlayedCards.Add(PlayerOne.PlayCard());
                playerTwoPlayedCards.Add(PlayerTwo.PlayCard());

                outputText += string.Format("{0} of {1} versus {2} of {3}<br />",
                playerOnePlayedCards.Last().Name, playerOnePlayedCards.Last().Suite,
                playerTwoPlayedCards.Last().Name, playerTwoPlayedCards.Last().Suite);


                if (playerOnePlayedCards.Last().Value ==
                    playerTwoPlayedCards.Last().Value)
                {
                    //Played Cards are equal, time for war!
                    outputText += "++++++ WAR! ++++++++ <br />";
                    addWarBounty(playerOnePlayedCards, playerTwoPlayedCards);
                    comparePlayedCards(playerOnePlayedCards, playerTwoPlayedCards);

                }
                else if (playerOnePlayedCards.Last().Value >
                    playerTwoPlayedCards.Last().Value)
                {
                    //Player one wins all the cards
                    return true;
                }
                else
                {
                    //Player two wins all the cards
                    return false;
                }
            }
            else
            {
                if(PlayerOne.CardHand.Count <= 0)
                {
                    //Player two wins by default
                    return false;

                }
                else if (PlayerTwo.CardHand.Count <= 0)
                {
                    //Player one wins by default
                    return true;
                }
                else
                {
                    //Both players ran out of cards.

                }
            }           
            
            return false;

        }

        private void addWarBounty(List<Card> playerOnePlayedCards, List<Card> playerTwoPlayedCards)
        {
            //Each player puts down three cards
            for (int i = 0; i < 3; i++)
            {
                playerOnePlayedCards.Add(PlayerOne.PlayCard());
                playerTwoPlayedCards.Add(PlayerTwo.PlayCard());
                outputText += string.Format("{0} of {1}&nbsp;&nbsp;-&nbsp;&nbsp;{2} of {3}<br />",
                    playerOnePlayedCards.Last().Name, playerOnePlayedCards.Last().Suite,
                    playerTwoPlayedCards.Last().Name, playerTwoPlayedCards.Last().Suite);
            }
            
        }

        private void DealCards()
        {
            bool playerToggle = true;

            while(GameCardsDeck.CountCardsInDeck() > 0)
            {
                if (playerToggle)
                {
                    //Deal card to player 1
                    PlayerOne.ReceiveCard(GameCardsDeck.DealCard());
                    playerToggle = !playerToggle;                   
                    
                }
                else
                {
                    //Deal card to player 2
                    PlayerTwo.ReceiveCard(GameCardsDeck.DealCard());
                    playerToggle = !playerToggle;
                }
            }
        }
    }
}