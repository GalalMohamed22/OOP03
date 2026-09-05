using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, int weight, decimal deliveryFee) : base(trackingCode, description, weight, deliveryFee)
        {

        }

        public override decimal EstimatedCost => base.EstimatedCost;

        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode: {TrackingCode}\n Description: {Description}\n Weight: {Weight} KG\n DeliveryFee: {DeliveryFee} EGP\n Estimated Cost: {EstimatedCost} EGP\n");
        }

    }
}
