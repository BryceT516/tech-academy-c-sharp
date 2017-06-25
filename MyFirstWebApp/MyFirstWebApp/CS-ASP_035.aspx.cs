using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class CS_ASP_035 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void challengeOneButton_Click(object sender, EventArgs e)
        {
            string initialString = "Bryce Tucker";

            string stringResult = "";

            for(int i = initialString.Length - 1; i >= 0; i--)
            {
                stringResult += initialString[i].ToString();
            }
            challengeOneLabel.Text = stringResult;

        }

        protected void challengeTwoButton_Click(object sender, EventArgs e)
        {
            string names = "Luke,Leia,Han,Chewbacca";

            string[] namesArray = names.Split(',');

            string namesReversed = "";

            for(int i = namesArray.Length - 1; i >=0; i--)
            {
                namesReversed += namesArray[i];
                if(i != 0)
                {
                    namesReversed += ",";
                }                                
            }

            challengeTwoLabel.Text = namesReversed;
        }

        protected void challengeThreeButton_Click(object sender, EventArgs e)
        {

            string names = "Luke,Leia,Han,Chewbacca";

            string[] namesArray = names.Split(',');

            string resultString = "<br />";
            int stringLength = 0;
            int totalOutputLength = 14;
            int frontPadding = 0;
            string partOne = "";

            for(int i = 0; i < namesArray.Length; i++)
            {
                stringLength = namesArray[i].Length;
                frontPadding = (totalOutputLength - stringLength) / 2;

                partOne = namesArray[i].PadLeft(frontPadding + stringLength, '*');
                resultString += partOne.PadRight(totalOutputLength,'*');
                resultString += "<br />";
            }

            challengeThreeLabel.Text = resultString;
        }

        protected void challengeFourButton_Click(object sender, EventArgs e)
        {
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            
            puzzle = puzzle.Remove(puzzle.IndexOf("remove-me"), 9);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            string startString = puzzle.Substring(0, 1);
            puzzle = puzzle.Remove(0, 1);
            startString = startString.ToUpper();

            string result = "";
            result += startString;
            result += puzzle;

            challengeFourLabel.Text = result;

        }
    }
}