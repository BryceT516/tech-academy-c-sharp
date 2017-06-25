using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class CS_ASP_010 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstValueTextBox.Text);
            double j = double.Parse(secondValueTextBox.Text);

            double result = i + j;

            resultLabel.Text = result.ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstValueTextBox.Text);
            double j = double.Parse(secondValueTextBox.Text);

            double result = i - j;

            resultLabel.Text = result.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstValueTextBox.Text);
            double j = double.Parse(secondValueTextBox.Text);

            double result;
            checked
            {
                result = i * j;
            }
            

            resultLabel.Text = result.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstValueTextBox.Text);
            double j = double.Parse(secondValueTextBox.Text);

            double result;
            checked
            {
                result = i / j;
            }


            resultLabel.Text = result.ToString();
        }
    }
}