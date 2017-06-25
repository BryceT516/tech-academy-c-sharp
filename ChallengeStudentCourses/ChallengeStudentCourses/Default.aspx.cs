using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */
            List<Course> currentCourses = new List<Course>()
            {
                new Course()
                {
                    CourseId=101, Name="Introductory Programming", Students=new List<Student>()
                    {
                        new Student()
                        {
                            StudentId=11111, Name="Bob"
                        },
                        new Student()
                        {
                            StudentId=22222, Name="Carol"
                        },
                        new Student()
                        {
                            StudentId=33333, Name="Beth"
                        }
                    }
                },
                new Course()
                {
                    CourseId=202, Name="Intermediate Programming", Students=new List<Student>()
                    {
                        new Student()
                        {
                            StudentId=44444, Name="Bill"
                        },
                        new Student()
                        {
                            StudentId=22222, Name="Carol"
                        },
                        new Student()
                        {
                            StudentId=55555, Name="Harold"
                        }
                    }
                },
                new Course()
                {
                    CourseId=303, Name="Advanced Programming", Students=new List<Student>()
                    {
                        new Student()
                        {
                            StudentId=66666, Name="Sophia"
                        },
                        new Student()
                        {
                            StudentId=77777, Name="Fiona"
                        },
                        new Student()
                        {
                            StudentId=88888, Name="Sam"
                        }
                    }
                }
            };

            string resultText = "";

            foreach (var course in currentCourses)
            {
                resultText += string.Format( "Course: {0}, {1}<br />&nbsp;-&nbsp;Students:<br />", course.CourseId.ToString(), course.Name);
                foreach (var student in course.Students)
                {
                    resultText += string.Format( "&nbsp;&nbsp;&nbsp;-{0} - {1}<br />", student.StudentId.ToString(), student.Name);
                }
            }

            resultLabel.Text = resultText;

        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Dictionary<int, Student> Students = new Dictionary<int, Student>();
            Students.Add(11111, new Student
            {
                Name = "Bob",
                Courses = new List<Course>() {
                new Course(){CourseId=101, Name="Programming Basics" },
                new Course(){CourseId=202, Name="Intermediate Programming"}
                }
            });
            Students.Add(22222, new Student
            {
                Name = "Belle",
                Courses = new List<Course>() {
                new Course(){CourseId=202, Name="Intermediate Programming" },
                new Course(){CourseId=303, Name="Advanced Programming"}
                }
            });
            Students.Add(33333, new Student
            {
                Name = "Tom",
                Courses = new List<Course>() {
                new Course(){CourseId=101, Name="Programming Basics" },
                new Course(){CourseId=202, Name="Intermediate Programming"}
                }
            });

            string resultingText = "";

            foreach (var student in Students)
            {
                resultingText += string.Format("Student ID: {0} <br />Name: {1}<br />", student.Key.ToString(), student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultingText += string.Format("&nbsp;{0} - {1}<br />", course.CourseId.ToString(), course.Name);
                }

            }

            resultLabel.Text = resultingText;

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */
            List<Student> GradedStudents = new List<Student>()
             {
                 new Student()
                 {
                     StudentId=11111, Name="Bob", Courses=new List<Course>()
                     {
                         new Course()
                         {
                             CourseId=101, Name="Introductory Programming", Grade=89
                         },
                         new Course()
                         {
                             CourseId=202, Name="Intermediate Programming", Grade=90
                         }
                     }
                 },
                 new Student()
                 {
                     StudentId=11111, Name="Carol", Courses=new List<Course>()
                     {
                         new Course()
                         {
                             CourseId=101, Name="Introductory Programming", Grade=95
                         },
                         new Course()
                         {
                             CourseId=202, Name="Intermediate Programming", Grade=88
                         }
                     }
                 },
                 new Student()
                 {
                     StudentId=11111, Name="Bill", Courses=new List<Course>()
                     {
                         new Course()
                         {
                             CourseId=101, Name="Introductory Programming", Grade=80
                         },
                         new Course()
                         {
                             CourseId=202, Name="Intermediate Programming", Grade=85
                         }
                     }
                 }
             };

            string resultingText = "";

            foreach (var student in GradedStudents)
            {
                resultingText += string.Format("Student ID: {0} <br />Name: {1}<br />", student.StudentId.ToString(), student.Name);
                foreach (var course in student.Courses)
                {
                    resultingText += string.Format("&nbsp;{0} - {1}, Grade: {2}<br />", course.CourseId.ToString(), course.Name, course.Grade);
                }

            }

            resultLabel.Text = resultingText;

        }
    }
}