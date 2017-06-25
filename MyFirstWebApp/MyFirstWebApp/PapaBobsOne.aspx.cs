using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class PapaBobsOne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sizeBabyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            totalUpOrder(sender, e);
        }

        protected void totalUpOrder(object sender, EventArgs e)
        {
            //Check all the options and create the order total
            double sizePrice = 0;
            double crustPrice = 0;
            double ingredientsPrice = 0;
            double grandTotalPrice = 0;
            string orderInfo = "";

            //Get size price
            if (sizeBabyRadioButton.Checked)
            {
                sizePrice = 10;
                orderInfo = "Baby Bob size: $10";
            }
            else if (sizeMamaRadioButton.Checked)
            {
                sizePrice = 13;
                orderInfo = "Mama Bob size: $13";
            }
            else if (sizePapaRadioButton.Checked)
            {
                sizePrice = 16;
                orderInfo = "Papa Bob size: $16";
            }
            else
            {
                sizePrice = 0;
                orderInfo = "Please select a size";
            }

            //Get crust price
            if (crustThinRadioButton.Checked)
            {
                crustPrice = 0;
                orderInfo += "<br/>Thin Crust: $0";
            }
            else if (crustThickRadioButton.Checked)
            {
                crustPrice = 2;
                orderInfo += "<br/>Deep Dish: $2.00";
            }
            else
            {
                crustPrice = 0;
                orderInfo += "<br/>Please choose a crust";
            }

            //Get ingredients price
            if (ingPepperoniCheckBox.Checked)
            {
                ingredientsPrice += 1.50;
                orderInfo += "<br/>Pepperoni: $1.50";
            }
            if (ingOnionsCheckBox.Checked)
            {
                ingredientsPrice += .75;
                orderInfo += "<br/>Onions: $0.75";
            }
            if (ingGreenPeppersCheckBox.Checked)
            {
                ingredientsPrice += .50;
                orderInfo += "<br/>Green Peppers: $0.50";
            }
            if (ingRedPeppersCheckBox.Checked)
            {
                ingredientsPrice += .75;
                orderInfo += "<br/>Red Peppers: $0.75";
            }
            if (ingAnchoviesCheckBox.Checked)
            {
                ingredientsPrice += 2;
                orderInfo += "<br/>Anchovies: $2.00";
            }


            grandTotalPrice = sizePrice + crustPrice + ingredientsPrice;

            if((ingPepperoniCheckBox.Checked
                && ingGreenPeppersCheckBox.Checked
                && ingAnchoviesCheckBox.Checked)
                ||
                (ingPepperoniCheckBox.Checked
                && ingRedPeppersCheckBox.Checked
                && ingOnionsCheckBox.Checked))
            {
                grandTotalPrice -= 2;
                orderInfo += "<br/>Special Deal: -$2.00";
            }

            //Output
            orderLabel.Text = orderInfo;
            orderTotalLabel.Text = grandTotalPrice.ToString();

        }

        protected void sizeMamaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            totalUpOrder(sender, e);
        }

        protected void sizePapaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            totalUpOrder(sender, e);
        }

        protected void crustThinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            totalUpOrder(sender, e);
        }

        protected void crustThickRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            totalUpOrder(sender, e);
        }

        protected void ingPepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            totalUpOrder(sender, e);
        }

        protected void ingOnionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            totalUpOrder(sender, e);
        }

        protected void ingGreenPeppersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            totalUpOrder(sender, e);
        }

        protected void ingRedPeppersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            totalUpOrder(sender, e);
        }

        protected void ingAnchoviesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            totalUpOrder(sender, e);
        }
    }
}