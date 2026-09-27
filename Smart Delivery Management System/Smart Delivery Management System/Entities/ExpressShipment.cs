using System;
using Assignment09.Entities;

namespace Assignment09.Inheritance
{
    public class ExpressShipment : Shipment
    {
        public decimal ExtraFee { get; set; }

        public ExpressShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            ExtraFee = extraFee;
            UpdateTrackingStatus("Out For Delivery");
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {DeliveryFee + (Weight * 5) + ExtraFee} EGP");
        }
    }
}