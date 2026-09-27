using System;

namespace Assignment09.Entities
{
    public abstract class Shipment
    {
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }
        public DeliveryAddress Destination { get; set; }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public Shipment CopyShipment()
        {
            return (Shipment)MemberwiseClone();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }

        public abstract void PrintShipment();
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)MemberwiseClone();

            copy.Destination = new DeliveryAddress(
                Destination.City,
                Destination.Street,
                Destination.BuildingNumber);

            return copy;
        }
    }
}