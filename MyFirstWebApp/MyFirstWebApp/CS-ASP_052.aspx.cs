using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class CS_ASP_052 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var myGuid = Guid.NewGuid();

            resultLabel.Text = myGuid.ToString();
        }
    }
}