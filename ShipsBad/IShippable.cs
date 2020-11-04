using System;
using System.Collections.Generic;
using System.Text;

namespace ShipsBad
{
    interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
