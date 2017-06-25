using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class CS_ASP_054 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            const int hoursPerDay = 24;

            //Calculate a constant
            const double daysPerWeek = (double)CalendarInfo.days / (double)CalendarInfo.weeks;


        }
    }
}