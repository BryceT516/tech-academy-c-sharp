using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class CS_ASP_012 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {            
            if (penRadioButton.Checked){
                resultLabel.Text = "Hope you don't run out of ink.";
                resultImage.ImageUrl = "http://www.montblanc.com/content/dam/mtb/products/writing-instruments/112/895/112895/197960-ecom-retina-01.png";
            }
            else if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "Keep that thing sharp.";
                resultImage.ImageUrl = "https://image.freepik.com/free-vector/writting-pencil-design_1095-187.jpg";
            }
            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "Isn't that screen kind of small?";
                resultImage.ImageUrl = "https://www.macobserver.com/imgs/teaser_images/google-smartphone.jpg";
            }
            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = "Hope you charged it.";
                resultImage.ImageUrl = "http://www.bell.ca/Styles/wireless/all_languages/all_regions/catalog_images/large/mobile/front/iPadAir_SpaceGrey_en.png";
            }
            else
            {
                resultLabel.Text = "Please select something.";
            }
        }
    }
}