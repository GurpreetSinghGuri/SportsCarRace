using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsCarRace
{
    public class Car  // This function is for car positioning //
    {
        public int startPosition { get; set; }
        public int finishPosition { get; set; }
        public PictureBox carImg { get; set; }  // This is picture box //
        private Random rand = new Random(); // This is a random function for car race //

        public bool AccelerateCar()   //This function is for racing//
        {
            Point currentPosition = carImg.Location;
            currentPosition.X += rand.Next(1, 6);
            carImg.Location = currentPosition;

            if (currentPosition.X >= finishPosition)
                return true;
            else
                return false;
        }

        public void BackToStart()   // This function will start again //
        {
            carImg.Left = startPosition;
        }
    }
}
