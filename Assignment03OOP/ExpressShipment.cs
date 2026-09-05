using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class ExpressShipment : Shipment
    {
        public ExpressShipment(string trackingCode, string description, int weight, decimal deliveryFee, decimal extraFee) : base(trackingCode, description, weight, deliveryFee)
        {
            ExtraFee = extraFee;
        }
        private decimal extraFee;

        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                extraFee = value >= 0 ? value : 0;
            }
        }

        public override decimal EstimatedCost => base.EstimatedCost + ExtraFee;

        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode: {TrackingCode}\n Description: {Description}\n Weight: {Weight} KG\n DeliveryFee: {DeliveryFee} EGP\n Estimated Cost: {EstimatedCost} EGP\n Extra Fee: {ExtraFee} EGP\n");
        }

    }
}
