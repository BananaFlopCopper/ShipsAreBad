using System;
using System.Collections.Generic;
using System.Text;

namespace ShipsBad
{
    class Bicycle : IShippable

    {
        public static int Bikes = 0;

        public Bicycle ()
        {
            Bikes++;
        }
        public decimal ShipCost => 20.50m;
        public string Product => "Bicycle"; 
    }
}
