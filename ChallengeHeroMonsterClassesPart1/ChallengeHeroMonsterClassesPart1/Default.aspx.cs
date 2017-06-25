using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        private Character hero = new Character();
        private Character monster = new Character();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack)
            {                
                hero = (Character)Session["Hero"];
                monster = (Character)Session["Monster"];
            }
            else
            {
                hero.Name = "Bob";
                hero.Health = 100;
                hero.AttackBonus = false;
                hero.DamageMaximum = 20;
                Session["Hero"] = hero;

                monster.Name = "Goblin";
                monster.Health = 100;
                monster.AttackBonus = false;
                monster.DamageMaximum = 25;
                Session["Monster"] = monster;

                printStats(hero, monster);

            }

            

        }

        protected void battleButton_Click(object sender, EventArgs e)
        {
            int damage = hero.Attack();
            monster.Defend(damage);
            showBattleExchange(hero, damage, monster);

            damage = monster.Attack();
            hero.Defend(damage);
            showBattleExchange(monster, damage, hero);

            Session["Hero"] = hero;
            Session["Monster"] = monster;

            printStats(hero, monster);

            if (winConditionCheck(hero, monster))
            {
                //Someone has won
                showWinner(hero, monster);
            } 
        }

        private void showWinner(Character hero, Character monster)
        {
            battleButton.Visible = false;
            
            if(hero.Health <= 0 && monster.Health <= 0)
            {
                //Both died
                battleExchangeLabel.Text = "The hero and monster both died.<br />" + battleExchangeLabel.Text;
            }
            else if (hero.Health <= 0)
            {
                //Hero died
                battleExchangeLabel.Text += "The monster won.<br />" + battleExchangeLabel.Text;
            }
            else if (monster.Health <= 0)
            {
                //Monster died
                battleExchangeLabel.Text += "The hero won.<br />" + battleExchangeLabel.Text;
            }
            else
            {
                //Shouldn't happen.
            }

        }

        private bool winConditionCheck(Character hero, Character monster)
        {
            if(hero.Health <= 0 || monster.Health <= 0)
            {
                return true;
            }

            return false;
        }

        private void showBattleExchange(Character attacker, int damage, Character defender)
        {
            battleExchangeLabel.Text = string.Format("<br /><hr /><br />{0} does {1} points of damage to {2}", attacker.Name, damage.ToString(), defender.Name) + battleExchangeLabel.Text;
        }

        private void printStats(Character hero, Character monster)
        {
            heroNameLabel.Text = hero.Name;
            heroHealthLabel.Text = hero.Health.ToString();

            monsterNameLabel.Text = monster.Name;
            monsterHealthLabel.Text = monster.Health.ToString();
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        private static Random randomGenerator = new Random();

        public int Attack()
        {
            return randomGenerator.Next(DamageMaximum);
        }

        public void Defend(int damageReceived)
        {
            this.Health -= damageReceived;
        }
    }
}