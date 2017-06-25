using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                shippingGroundRadioButton.Checked = true;
            }
        }

        private void CalculateShipping()
        {
            if(!CheckInputValues())
            {
                DisplayMessage("Package height and width are required values. Length is optional.");
            }
            else
            {
                double height = double.Parse(heightTextBox.Text);
                double width = double.Parse(widthTextBox.Text);
                double length = (lengthTextBox.Text.Trim().Length == 0)? 1 : double.Parse(lengthTextBox.Text);

                double volume = CalculateVolume(height, width, length);

                if (shippingGroundRadioButton.Checked)
                {
                    DisplayShippingCost(CalculateCost(volume, 0.15));
                }
                else if (shippingAirRadioButton.Checked)
                {
                    DisplayShippingCost(CalculateCost(volume, 0.25));
                }
                else if (shippingNextDayRadioButton.Checked)
                {
                    DisplayShippingCost(CalculateCost(volume, 0.45));
                }
                else
                {
                    DisplayMessage("Please select a shipping method.");
                }
            }
        }

        private bool CheckInputValues()
        {
            double result = 1;
            if (!double.TryParse(heightTextBox.Text, out result))
            {
                return false;
            }

            if (result <= 0)
            {
                return false;
            }

            if (!double.TryParse(widthTextBox.Text, out result))
            {
                return false;
            }

            if (result <= 0)
            {
                return false;
            }

            if (!double.TryParse(lengthTextBox.Text, out result))
            {
                return false;
            }

            return true;
        }

        private double CalculateCost(double volumeInput, double shippingRate)
        {
            return volumeInput * shippingRate;
        }

        private void DisplayMessage(string messageOut)
        {
            resultLabel.Text = messageOut;
        }

        private double CalculateVolume(double heightInput, double widthInput, double lengthInput = 1)
        {
            return heightInput * widthInput * lengthInput;
        }

        private void DisplayShippingCost(double shippingCost)
        {
            resultLabel.Text = string.Format("{0:C}", shippingCost);
        }

        protected void OnChange(object sender, EventArgs e)
        {
            CalculateShipping();
        }
        
    }
}