using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsCarRace
{
    abstract class Data     // This is abstract class //
    {
        public static Car[] Cars = new Car[4];
        public static Bettor[] Bidders = new Bettor[3];
        public static Random rand = new Random();
        public static int CurrentGambler { get; set; }
    }
}
