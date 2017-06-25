using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DartsLib;

namespace ChallengeSimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();
            GameManager DartsGame = new GameManager(randomGenerator);
            resultLabel.Text = DartsGame.PlayGame();
        }

    }

    public class GameManager
    {
        public Player _playerOne { get; set; }
        public Player _playerTwo { get; set; }
        public Random _randomGenerator { get; set; }

        public GameManager(Random randomGenerator)
        {
            _randomGenerator = randomGenerator;
            _playerOne = new Player(randomGenerator);
            _playerTwo = new Player(randomGenerator);
        }

        public string PlayGame()
        {
            int rounds = 0;
            while (_playerOne.Score < 300 && _playerTwo.Score < 300)
            {
                rounds++;
                for(int i = 0; i < 3; i++)
                {
                    _playerOne.Score += EvaluateThrow(_playerOne.Dart);
                }
                for (int i = 0; i < 3; i++)
                {
                    _playerTwo.Score += EvaluateThrow(_playerTwo.Dart);
                }
            }

            return string.Format("<br />Rounds: {0}" +
                "<br />Player One: {1} <br />Player Two: {2}",
                rounds, _playerOne.Score, _playerTwo.Score);
        }

        private int EvaluateThrow(Dart playersDart)
        {
            string sectionHit;
            bool doubleRingHit;
            bool tripleRingHit;

            playersDart.Throw(out sectionHit, out doubleRingHit, out tripleRingHit);

            return GetDartValue(sectionHit, doubleRingHit, tripleRingHit);
        }

        private int GetDartValue(string sectionHit, bool doubleRingHit, bool tripleRingHit)
        {
            int returnValue = 0;

            if (sectionHit == "InnerBullseye")
            {
                return 50;
            }
            else if (sectionHit == "OuterBullseye")
            {
                return 25;
            }
            else if (sectionHit == "Miss")
            {
                return 0;
            }
            else
            {
                returnValue = int.Parse(sectionHit);
                if (doubleRingHit)
                {
                    return returnValue * 2;
                }
                else if (tripleRingHit)
                {
                    return returnValue * 3;
                }                
            }
        return returnValue;
        }
    }

    public class Player
    {
        public int Score { get; set; }
        public Dart Dart { get; set; }

        public Player(Random randomGenerator)
        {
            Score = 0;
            Dart = new Dart(randomGenerator);
        }

    }
}