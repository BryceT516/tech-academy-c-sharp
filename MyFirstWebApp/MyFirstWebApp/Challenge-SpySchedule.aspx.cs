using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class Challenge_SpySchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                oldAssignmentEndCalendar.SelectedDate = DateTime.Now.Date;
                newAssignementStartCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                newAssignementStartCalendar.VisibleDate = newAssignementStartCalendar.SelectedDate;
                newAssignmentEndCalendar.SelectedDate = newAssignementStartCalendar.SelectedDate.Date.AddDays(21);
                newAssignmentEndCalendar.VisibleDate = newAssignmentEndCalendar.SelectedDate;
            }
        }

        protected void assignSpyButton_Click(object sender, EventArgs e)
        {
            DateTime oldAssignmentEndDate = oldAssignmentEndCalendar.SelectedDate;
            DateTime newAssignmentStartDate = newAssignementStartCalendar.SelectedDate;
            DateTime newAssignmentEndDate = newAssignmentEndCalendar.SelectedDate;

            //Validation: make sure the use has the dates in order:
            if (oldAssignmentEndDate > newAssignmentStartDate)
            {
                //They selected a start date before the prior end date
                resultsLabel.Text = "<span class='text-danger'>The new assignment start date must be after the end of the old assignment.</span>";
            }
            else
            {
                //Get a difference value between the end of the old assignment and the beginning of the
                // new assignment.
                TimeSpan spyDowntime = newAssignmentStartDate.Subtract(oldAssignmentEndDate);
                if(spyDowntime.TotalDays < 14)
                {
                    resultsLabel.Text = "<span class='text-danger'>Spy Union rule 54-13 subparagraph 8 requires a minimum of 14 days " +
                        "downtime between assignments. Please adjust assignment dates accordingly.</span>";
                }
                else
                {
                    TimeSpan assignmentProjectedDuration = newAssignmentEndDate.Subtract(newAssignmentStartDate);
                    if(assignmentProjectedDuration.TotalDays < 1)
                    {
                        resultsLabel.Text = "<span class='text-danger'>New assignment duration must be at least 1 day.</span>";
                    }
                    else
                    {
                        double newAssignmentBudget = 0;
                        if (assignmentProjectedDuration.TotalDays >= 21)
                        {
                            newAssignmentBudget = (500 * assignmentProjectedDuration.TotalDays) + 1000;
                        }
                        else
                        {
                            newAssignmentBudget = 500 * assignmentProjectedDuration.TotalDays;
                        }

                        resultsLabel.Text = String.Format("<span class='text-success'>Assignment of {0} to assignment Project: {1} is authorized." +
                            " Budget total: {2:C}</span>", 
                            spyNameTextBox.Text,
                            assignmentNameTextBox.Text,
                            newAssignmentBudget);
                        
                    }
                    


                }
            }
            

        }
    }
}