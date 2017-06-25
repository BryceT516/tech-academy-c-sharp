using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CasinoMegaChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        int playerBalance;
        Random randomValue = new Random();
        string[] imagesArray = new string[] {
            "Bar.png", "Bell.png", "Cherry.png", "Clover.png",
            "Diamond.png", "HorseShoe.png", "Lemon.png", "Orange.png",
            "Plum.png", "Seven.png", "Strawberry.png", "Watermelon.png"
        };

        int spinnerOne;
        int spinnerTwo;
        int spinnerThree;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Initial page load
                Session["playerBalance"] = 100;
                playerBalance = 100;
                balanceLabel.Text = playerBalance.ToString();
            }
            else
            {
                playerBalance = Convert.ToInt32(Session["playerBalance"]);
            }
        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            if (ValidateBet())
            {
                //Bet is valid, continue.
                //Determine random values for each spinner
                spinnerOne = randomValue.Next(11);
                spinnerTwo = randomValue.Next(11);
                spinnerThree = randomValue.Next(11);

                //Display the images for each spinner
                DisplayImages();

                //Determine the multiplier or losing
                int fundsChangeAmount = DetermineSpinResult();

                DisplayResultMessage(fundsChangeAmount);


                //Determine the new player balance
                UpdatePlayerFunds(fundsChangeAmount);
            }
            else
            {
                //Bet entry is invalid, provide a message.
                resultLabel.Text = "Please enter a valid amount for your bet.";
            }



        }

        private bool ValidateBet()
        {
            int betAmount = 0;
            if (int.TryParse(betInputTextBox.Text, out betAmount))
            {
                if(betAmount > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void UpdatePlayerFunds(int fundsChangeAmount)
        {
            playerBalance += fundsChangeAmount;
            
            balanceLabel.Text = playerBalance.ToString();

            Session["playerBalance"] = Convert.ToString(playerBalance); 
        }

        private void DisplayResultMessage(int fundsChangeAmount)
        {

            if(fundsChangeAmount > 0)
            {
                //Display winning message
                resultLabel.Text = string.Format("You bet {0:C} and won {1:C}!", GetBetAmount(), fundsChangeAmount);

            }
            else if (fundsChangeAmount < 0)
            {
                //Display losing message
                resultLabel.Text = string.Format("Sorry, you lose {0:C}. Try again.", fundsChangeAmount);
            }
        }

        private int DetermineSpinResult()
        {
            //Determine the amount funds changing
            return GetBetAmount() * GetResultMultiplier();
            
        }

        private int GetResultMultiplier()
        {
            int cherryCountResult = 0;
            if(spinnerOne == 0 || spinnerTwo == 0 || spinnerThree == 0)
            {
                //There is a BAR, player loses
                return (-1);
            }
            else if (GetCherryCount(out cherryCountResult))
            {
                //There are cherries, return a multiplier based on the number
                if (cherryCountResult == 1)
                {
                    //One cherry
                    return 2;
                }
                else if (cherryCountResult == 2)
                {
                    //Two cherries
                    return 3;
                }
                else
                {
                    //Three cherries
                    return 4;
                }
            }
            else if (CheckSevens())
            {
                //There are 3 sevens, Jackpot!
                return 100;
            }
            else
            {
                //Not a winner
                return (-1);
            }

        }

        private bool CheckSevens()
        {
            if(spinnerOne == 9 && spinnerTwo == 9 && spinnerThree == 9)
            {
                return true;
            }

            return false;
        }

        private bool GetCherryCount(out int cherryCountResult)
        {
            cherryCountResult = 0;
            bool returnVal = false;
            if(spinnerOne == 2)
            {
                returnVal = true;
                cherryCountResult++;
            }
            if (spinnerTwo == 2)
            {
                returnVal = true;
                cherryCountResult++;
            }
            if (spinnerThree == 2)
            {
                returnVal = true;
                cherryCountResult++;
            }

            return returnVal;

        }

        private int GetBetAmount()
        {
            return int.Parse(betInputTextBox.Text);
        }

        private void DisplayImages()
        {
            cellOneImage.ImageUrl = "Images/" + imagesArray[spinnerOne];
            cellTwoImage.ImageUrl = "Images/" + imagesArray[spinnerTwo];
            cellThreeImage.ImageUrl = "Images/" + imagesArray[spinnerThree];
        }

    }
}