using System;
using System.Collections.Generic;
using System.Text;

namespace ShipsBad
{
    class Lawn_mower : IShippable
    {
        public static int Mowers = 0;

        public Lawn_mower ()
        {
            Mowers++;
        }
        public decimal ShipCost => 24.00M;
        public string Product => "Lawn mower";
    }
}
