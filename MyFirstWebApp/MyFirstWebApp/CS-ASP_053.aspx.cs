using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class CS_ASP_053 : System.Web.UI.Page
    {
        public List<Character> Heroes { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Heroes = new List<Character>();
            }
            else
            {
                Heroes = (List<Character>) Session["HeroesList"];
                if(Heroes == null)
                {
                    Heroes = new List<Character>();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Character newHero = new Character();
            newHero.Name = TextBox1.Text;
            TextBox1.Text = "";

            CharacterType selectedType;
            if(Enum.TryParse(DropDownList1.SelectedValue, out selectedType))
            {
                newHero.Type = selectedType;
                Heroes.Add(newHero);
                Session["HeroesList"] = Heroes;
            }
                
            
            if(Heroes != null)
            {
                resultLabel.Text = "";
                foreach (var hero in Heroes)
                {
                    resultLabel.Text += string.Format("{0} the {1}<br />", hero.Name, hero.Type);
                }
            }
            
        }
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