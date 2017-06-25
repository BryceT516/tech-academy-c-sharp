using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class CS_ASP_011 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            string firstVal = firstTextBox.Text;
            string secondVal = secondTextBox.Text;
            resultLabel.Text = "";

            if(firstVal == secondVal)
            {
                resultLabel.Text = "Yes! They're equal!";
            }
            else
            {
                resultLabel.Text = "No! They're not equal!";
            }

            if (firstCheckBox.Checked)
            {
                resultLabel.Text = resultLabel.Text + "And you are cool!";
            }
            else
            {
                resultLabel.Text = resultLabel.Text + "And don't be so hard on yourself.";
            }
        }
    }
}