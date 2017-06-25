using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class CS_ASP_036 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myNewCar = new Car();

            
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

    }
}