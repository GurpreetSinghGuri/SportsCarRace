using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsCarRace
{
    public class Bettor : Bet  // This show the bet name and cash //
    {
        public string Name { get; set; }
        public int Cash { get; set; }
        public Bet CurrentBet;

        public RadioButton BettorSelector { get; set; }   // This is for radio buttons//
        public Label PlayerActivityIndicator { get; set; }

        public void UpdateLabels()   // this will update the cash of bet for particular bettor//
        {
            BettorSelector.Text = Name + " has $" + Cash;
        }

        public void Reset()   // This will show a message if bettor has not place any bet //
        {
            CurrentBet = null;
            PlayerActivityIndicator.Text = Name + " hasn't placed a bet";
        }

        public bool PlaceBid(int BidAmount, int VehicleToWin)  // This is for the amount which they are betting//
        {
            this.CurrentBet = new Bet() { Amount = BidAmount, car = VehicleToWin };

            if (BidAmount <= Cash)
            {
                PlayerActivityIndicator.Text = this.Name + " has placed $" + BidAmount + " Bid on Car #" + VehicleToWin;
                this.UpdateLabels();
                return true;
            }
            else // it tell if bettor does not has enough amount of price to bet on race//
            {
                MessageBox.Show(this.Name + " does not have enough cash to cover the Bid"); // This is alert message which tell that you do not have enough money //
                this.CurrentBet = null;
                return false;
            }
        }

        public void CollectYouMoney(int Winner)   // This function will tell about the winner //
        {
            if (this.CurrentBet != null)
            {
                Cash += CurrentBet.PayOut(Winner);
                Reset();
                UpdateLabels();
            }
        }
    }
}
