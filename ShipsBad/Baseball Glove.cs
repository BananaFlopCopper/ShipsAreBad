using System;
using System.Collections.Generic;
using System.Text;

namespace ShipsBad
{
    class Baseball_Glove : IShippable
    {
        public static int Gloves = 0;
        public Baseball_Glove()
        {
            Gloves++;
        }
        public decimal ShipCost => 3.23m;
        public string Product => "Baseball Glove";
    }
}
