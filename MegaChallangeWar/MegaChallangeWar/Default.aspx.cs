using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeWar
{
    public partial class Default : System.Web.UI.Page
    {
        public GameManager WarGameManager { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            WarGameManager = new GameManager();

        }

        protected void playButton_Click(object sender, EventArgs e)
        {


            WarGameManager.PlayGame();

            resultLabel.Text = WarGameManager.outputText;


        }
    }
}