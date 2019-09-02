   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsCarRace  // This is name for the assignment//
{
    public class Bet : Car // this shows how much money any bettor lose or win after race //
    {
        public int Amount { get; set; }
        public Bettor bettor { get; set; }
        public int car { get; set; }
        public int multiplier { get; set; }

        public string GetDescription()  //this is a string //
        {
            if (Amount == 0)
                return bettor.Name + " hasn't placed a bet";
            else
                return bettor.Name + " has placed $" + Amount + " on car #" + car;
        }

        public int PayOut(int Winner)  // it show the amount of winning and losing //
        {
            if (Winner == car)
            {
                return Amount * 2;
            }
            else
            {
                return (0 - Amount);
            }
        }
    }
}
