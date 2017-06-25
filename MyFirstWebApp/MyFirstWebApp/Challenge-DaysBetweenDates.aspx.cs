using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class Challenge_DaysBetweenDates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int compareTime = DateTime.Compare(dateOneCalendar.SelectedDate, dateTwoCalendar.SelectedDate);
            TimeSpan elapsedTime;
            if(compareTime < 0)
            {
                elapsedTime = dateTwoCalendar.SelectedDate.Subtract(dateOneCalendar.SelectedDate);
            }
            else if (compareTime == 0)
            {
                elapsedTime = new TimeSpan(0);
            }
            else
            {
                elapsedTime = dateOneCalendar.SelectedDate.Subtract(dateTwoCalendar.SelectedDate);
            }

            elapsedDaysLabel.Text = elapsedTime.TotalDays.ToString();
        }
    }
}