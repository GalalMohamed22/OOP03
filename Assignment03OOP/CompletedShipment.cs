using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, int weight, decimal deliveryFee) : base(trackingCode,description,weight, deliveryFee)
        {
            
        }

    }
}
