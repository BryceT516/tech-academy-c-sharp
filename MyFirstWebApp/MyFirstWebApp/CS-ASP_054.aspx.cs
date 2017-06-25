using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class CS_ASP_0541 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            string result = "";
            int switchExpression = 0;

            switch (switchExpression)
            {
                case 0:
                    result += "Case 0<br />";
                    break;
                case 1:
                    result += "Case 1<br />";
                    break;
                case 2:
                case 3:
                    result += "Case 2 or 3<br />";
                    break;
                case 4:
                    result += "Case 4<br />";
                    goto case 0;
                default:
                    result += "Default (Optional)<br />";
                    break;
            }
            */


            var hero = new Character();
            hero.Name = "Bob";
            hero.Type = CharacterType.Fighter;


            switch (hero.Type)
            {
                case CharacterType.Wizard:
                    resultLabel.Text += "Wizard";
                    break;
                case CharacterType.Fighter:
                    resultLabel.Text += "Fighter";
                    break;
                case CharacterType.Thief:
                    resultLabel.Text += "Thief";
                    break;
                case CharacterType.Cleric:
                    resultLabel.Text += "Cleric";
                    break;
                default:
                    break;
            }



            resultLabel.Text = result;

        }

        public class Character
        {
            public string Name { get; set; }
            public CharacterType Type { get; set; }

        }

        public enum CharacterType
        {
            Wizard,
            Fighter,
            Thief,
            Cleric
        }
    }
}