using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class CS_ASP_008 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            /*
            int i;
            i = "3";
            */

            /*
            int i = 2000000000;
            long j = i;

            long k = 2000000000;
            int l = (int)k;

            double d = 2.5;
            int r = (int)d;
            */
            //resultLabel.Text = r.ToString();

            string inputVal = inputTextBox.Text;
            int inputInt = int.Parse(inputVal);
            int result = inputInt + 1;

            resultLabel.Text = result.ToString();



        }
    }
}