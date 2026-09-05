using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Assignment03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            // a)  What is the difference between Method Overloading and Method Overriding?
            // Method Overloading occurs when multiple methods in the same class share the same name but have different parameters different in  type, number, or order
            // Method Overriding occurs when a subclass provides a specific implementation of a method that is already defined in its parent class


            // b)  What is the difference between Static Binding and Dynamic Binding? 
            // Static Binding occurs when the code to be executed is linked to the method call at compile time
            // Dynamic Binding occurs when the code to be executed is linked to the method call at runtime

            #endregion

            #region Question02

            //(a) The sealed keyword prevents other classes from inheriting or deriving from it



            // (c)
            // Sealed Class prevents other classes from inheriting from it entirely.
            // Sealed Method prevents a specific method from being overridden in child classes



            // (c) No, it cannot, The sealed modifier explicitly locks the method's implementation. 

            #endregion


            #region in Main

            //DeliveryCenter deliveryCenter = new DeliveryCenter();

            //Console.WriteLine("Enter name of driver:");
            //string name = Console.ReadLine();
            //deliveryCenter.driver = new Driver(name);


            //Console.WriteLine("------------Standard Shipment------------");
            //Console.WriteLine("Enter Tracking Code:");
            //string standardShipmentTrackingCode = Console.ReadLine();
            //Console.WriteLine("Enter Description:");
            //string standardShipmentDescription = Console.ReadLine();
            //Console.WriteLine("Enter Weight:");
            //int standardShipmentWeight = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Delivery Fee:");
            //decimal standardShipmentDeliveryFee = decimal.Parse(Console.ReadLine());


            //Console.WriteLine("------------Express Shipment------------");
            //Console.WriteLine("Enter Tracking Code:");
            //string ExpressShipmentTrackingCode = Console.ReadLine();
            //Console.WriteLine("Enter Description:");
            //string ExpressShipmentDescription = Console.ReadLine();
            //Console.WriteLine("Enter Weight:");
            //int ExpressShipmentWeight = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Delivery Fee:");
            //decimal ExpressShipmentDeliveryFee = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Extra Fee:");
            //decimal ExpressShipmentExtraFee = decimal.Parse(Console.ReadLine());


            //Console.WriteLine("------------International Shipment------------");
            //Console.WriteLine("Enter Tracking Code:");
            //string InternationalShipmentTrackingCode = Console.ReadLine();
            //Console.WriteLine("Enter Description:");
            //string InternationalShipmentDescription = Console.ReadLine();
            //Console.WriteLine("Enter Weight:");
            //int InternationalShipmentWeight = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Delivery Fee:");
            //decimal InternationalShipmentDeliveryFee = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Destination Country:");
            //string ExpressShipmentDestinationCountry = Console.ReadLine();
            //Console.WriteLine("Enter Customs Fee:");
            //decimal InternationalShipmentCustomsFee = decimal.Parse(Console.ReadLine());



            //StandardShipment standardShipment = new StandardShipment(standardShipmentTrackingCode, standardShipmentDescription, standardShipmentWeight, standardShipmentDeliveryFee);
            //ExpressShipment expressShipment = new ExpressShipment(ExpressShipmentTrackingCode, ExpressShipmentDescription, ExpressShipmentWeight, ExpressShipmentDeliveryFee, ExpressShipmentExtraFee);
            //InternationalShipment internationalShipment = new InternationalShipment(InternationalShipmentTrackingCode, InternationalShipmentDescription, InternationalShipmentWeight, InternationalShipmentDeliveryFee, ExpressShipmentDestinationCountry, InternationalShipmentCustomsFee);

            //deliveryCenter.AddShipment(standardShipment);
            //deliveryCenter.AddShipment(expressShipment);
            //deliveryCenter.AddShipment(internationalShipment);

            //deliveryCenter.PrintAllShipments();

            //Console.WriteLine("Printing Using Delivery Helper: ");
            //DeliveryHelper.PrintShipmentDetails(standardShipment);
            //DeliveryHelper.PrintShipmentDetails(expressShipment);
            //DeliveryHelper.PrintShipmentDetails(internationalShipment);


            //Console.WriteLine("Update Weight: ");
            //int UpdateWeight = int.Parse(Console.ReadLine());
            //Console.WriteLine("Extra Packing Weight: ");
            //int ExtraPackingWeight = int.Parse(Console.ReadLine());
            //standardShipment.UpdateWeight(UpdateWeight);
            //standardShipment.UpdateWeight(UpdateWeight, ExtraPackingWeight);

            //Shipment[] shipments = new Shipment[3];
            //shipments[0] = standardShipment;
            //shipments[1] = expressShipment;
            //shipments[2] = internationalShipment;


            //Console.WriteLine("Printing using Shipment[]: ");
            //foreach (Shipment sh in shipments)
            //{
            //    sh.PrintShipment();
            //}


            #endregion


        }
    }
}
