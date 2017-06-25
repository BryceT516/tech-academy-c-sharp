using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            string biggestBattler = "";
            int mostBattles = 0;
            string smallestBattler = "";
            int leastBattles = 100;


            for (int i = 0; i < names.Length; i++)
            {
                if(numbers[i] > mostBattles)
                {
                    biggestBattler = names[i];
                    mostBattles = numbers[i];
                }
                if(numbers[i] < leastBattles)
                {
                    smallestBattler = names[i];
                    leastBattles = numbers[i];
                }

            }
            result = string.Format("{0} has fought the most battles: {1} <br />" +
                "{2} has fought the least battles: {3}", 
                biggestBattler, mostBattles.ToString(), smallestBattler, leastBattles.ToString());

            resultLabel.Text = result;
        }
    }
}