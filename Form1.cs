using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsCarRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int StartRace = Car1.Left;
            int RaceTrackLength = TrackLength.Width - Car1.Right;

            Data.Cars[0] = new Car() { carImg = Car1, finishPosition = RaceTrackLength, startPosition = StartRace };
            Data.Cars[1] = new Car() { carImg = Car2, finishPosition = RaceTrackLength, startPosition = StartRace };
            Data.Cars[2] = new Car() { carImg = Car3, finishPosition = RaceTrackLength, startPosition = StartRace };
            Data.Cars[3] = new Car() { carImg = Car4, finishPosition = RaceTrackLength, startPosition = StartRace };

            Data.Bidders[0] = new Bettor() { Cash = 50, PlayerActivityIndicator = label1, BettorSelector = radioButton1, Name = "Player 1" };
            Data.Bidders[1] = new Bettor() { Cash = 50, PlayerActivityIndicator = label2, BettorSelector = radioButton2, Name = "Player 2" };
            Data.Bidders[2] = new Bettor() { Cash = 50, PlayerActivityIndicator = label3, BettorSelector = radioButton3, Name = "Player 3" };

            // Sets the default values to the labels
            Data.Bidders[0].UpdateLabels();
            Data.Bidders[1].UpdateLabels();
            Data.Bidders[2].UpdateLabels();
            Data.Bidders[0].Reset();
            Data.Bidders[1].Reset();
            Data.Bidders[2].Reset();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Data.Bidders[Data.CurrentGambler].PlaceBid((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            Data.Bidders[Data.CurrentGambler].UpdateLabels();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.Cars.Length; i++)
            {
                Data.Cars[Data.rand.Next(0, 4)].AccelerateCar();
                if (Data.Cars[i].AccelerateCar())
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    button2.Enabled = true;
                    DeclareWinner(i + 1);
                }
            }
        }

        private void ResetPositions()
        {
            Data.Cars[0].BackToStart();
            Data.Cars[1].BackToStart();
            Data.Cars[2].BackToStart();
            Data.Cars[3].BackToStart();
        }

        private void ResetBids()
        {
            label2.Text = "Player 1 hasn't placed a bet.";
            label2.Text = "Player 2 hasn't placed a bet.";
            label2.Text = "Player 3 hasn't placed a bet.";
        }

        private void DeclareWinner(int Winner)
        {
            MessageBox.Show("Car #" + Winner + " is the Winning Car");
            for (int i = 0; i < Data.Bidders.Length; i++)
            {
                Data.Bidders[i].CollectYouMoney(Winner);
                Data.Bidders[i].UpdateLabels();
                ResetPositions();
                ResetBids();
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Data.CurrentGambler = 0;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Data.CurrentGambler = 1;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Data.CurrentGambler = 2;
        }

        private void Car1_Click(object sender, EventArgs e)
        {

        }
    }
}
