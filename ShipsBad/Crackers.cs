using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ShipsBad
{
    class Crackers : IShippable
    {
        public static int Cracker = 0;

        public Crackers ()
        {
            Cracker++;
        }
        public decimal ShipCost => 0.57M;
        public string Product => "Crackers";
    }
}
