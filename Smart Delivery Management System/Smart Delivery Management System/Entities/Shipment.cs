using System;

namespace Assignment09.Entities
{
    public abstract partial class Shipment
    {
        public static int TotalShipmentsCreated;

        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }
        public DeliveryAddress Destination { get; set; }

        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

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

            TotalShipmentsCreated++;
        }

        public Shipment CopyShipment()
        {
            return (Shipment)MemberwiseClone();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)MemberwiseClone();

            copy.Destination = new DeliveryAddress(
                Destination.City,
                Destination.Street,
                Destination.BuildingNumber);

            return copy;
        }

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine(
                $"Tracking status changed to: {newStatus}");
        }

        public abstract void PrintShipment();
    }
}