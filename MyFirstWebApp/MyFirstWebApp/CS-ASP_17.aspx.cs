using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class CS_ASP_17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                inputTextTextBox.Text = "Some value.";
                dateSelectCalendar.SelectedDate = DateTime.Now.Date.AddDays(2);
            }
            
        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = inputTextTextBox.Text + " - "
                + dateSelectCalendar.SelectedDate.ToShortDateString();
        }
    }
}