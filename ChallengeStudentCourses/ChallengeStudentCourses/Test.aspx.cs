using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            // Create a list of courses
            List<Course> myCourses = new List<Course>();

            // Add courses to the list
            myCourses.Add(new Course());

            myCourses.ElementAt(0).CourseId = 1;
            myCourses.ElementAt(0).Name = "CS101 - Intro to Computer Programming";
            myCourses.ElementAt(0).Students = new List<Student>()
            {
                new Student() {StudentId=11111, Name="Bob"},
                new Student() {StudentId=22222, Name="Jill"},
                new Student() {StudentId=33333, Name="Bill"},
                new Student() {StudentId=44444, Name="Jane"}
            };

            bool isFirstItem = true;
            foreach (var course in myCourses)
            {
                resultLabel.Text = string.Format("Course ID: {0}, Course Name: {1}",
                    course.CourseId.ToString(), course.Name);
                resultLabel.Text += "<br />&nbsp;&nbsp;Students: ";

                foreach (var student in course.Students)
                {
                    if (isFirstItem)
                    {
                        resultLabel.Text += string.Format("{0}", student.Name);
                        isFirstItem = false;
                    }
                    else
                    {
                        resultLabel.Text += string.Format(", {0}", student.Name);
                    }
                        
                }
                resultLabel.Text += "<br />";
            }
            

        }
    }
}