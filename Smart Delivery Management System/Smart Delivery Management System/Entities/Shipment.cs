using System;

namespace Assignment09.Entities
{
    public abstract class Shipment
    {
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }

        public Shipment CopyShipment()
        {
            return (Shipment)MemberwiseClone();
        }

        public abstract void PrintShipment();
    }
}