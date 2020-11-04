using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace ShipsBad
{
    static class Shipper
    {
        private static List<IShippable> Shipments = new List<IShippable>();
        public static void Add(IShippable order)
        {
            Shipments.Add(order);
        }
        
        public static decimal Sum ()
        {
            Decimal sum = 0.00m;
            for (int i = 0; i < Shipments.Count; i++)
            {
                sum += Shipments[i].ShipCost;
            }
            return sum;
        }
        public static List<string> whatAmIShipping()
        {
            List<string> Shipping = new List<string>();
            Shipping.Add("Bicycles: " + Bicycle.Bikes);
            Shipping.Add("Lawn mowers: " + Lawn_mower.Mowers);
            Shipping.Add("Baseball Gloves: " + Baseball_Glove.Gloves);
            Shipping.Add("Crackers: " + Crackers.Cracker);
            return Shipping;
        }


    }
}
