   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsCarRace  // This is name for the assignment//
{
    public class Bet : Car // This is bet class for sportscarrace //
    {
        public int Amount { get; set; }
        public Bettor bettor { get; set; }
        public int car { get; set; }
        public int multiplier { get; set; }

        public string GetDescription() // This is for string//
        {
            if (Amount == 0)
                return bettor.Name + " hasn't placed a bet";
            else
                return bettor.Name + " has placed $" + Amount + " on car #" + car;
        }

        public int PayOut(int Winner)  // This is for integers//
        {
            if (Winner == car)
            {
                return Amount * 4;
            }
            else
            {
                return (0 - Amount);
            }
        }
    }
}
