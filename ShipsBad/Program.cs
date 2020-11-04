using System;

namespace ShipsBad
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
           
            bool notDone = true;
            int RealInput = 0;
            while (notDone)
            {
            Console.WriteLine(
                    "1. Add a Bicycle to the Shipment. \n" +
                    "2. Add a Lawn Mower to the Shipment. \n" +
                    "3. Add a Baseball Glove to the Shipment. \n" +
                    "4. Add Crackers to the Shipment. \n" +
                    "5. List Shipment Items. \n" +
                    "6. Compute Shipping Charges.");

                RealInput = 0;
                while (RealInput < 1 || RealInput > 6)
                {
                    Console.WriteLine("Enter a number from the list(1-6): ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out RealInput))
                    {
                        Console.WriteLine("Please enter a number(1-6).");
                    }
                }

                switch (RealInput)
                {
                    case 1:
                        Bicycle Bike = new Bicycle();
                        Shipper.Add(Bike);
                        Console.WriteLine("1 Bicycle has been added \n Press any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Lawn_mower Mower = new Lawn_mower();
                        Shipper.Add(Mower);
                        Console.WriteLine("1 Lawn mower has been added.\nPress any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Baseball_Glove Glove = new Baseball_Glove();
                        Shipper.Add(Glove);
                        Console.WriteLine("1 Baseball Glove has been added. \n Press any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Crackers nom = new Crackers();
                        Shipper.Add(nom);
                        Console.WriteLine("1 Crackers has been added. \n Press any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Current Shipments:");
                        Console.WriteLine(Shipper.whatAmIShipping()[0]);
                        Console.WriteLine(Shipper.whatAmIShipping()[1]);
                        Console.WriteLine(Shipper.whatAmIShipping()[2]);
                        Console.WriteLine(Shipper.whatAmIShipping()[3]);
                        Console.WriteLine("Press any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("$" + Shipper.Sum()); ;
                        notDone = false;
                        break;
                }
            }
            
        }
    }
}
