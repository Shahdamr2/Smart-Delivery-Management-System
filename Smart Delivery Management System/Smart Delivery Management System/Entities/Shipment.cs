using System;

namespace Assignment09.Entities
{
    public abstract class Shipment
    {
        public static int TotalShipmentsCreated;

        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }
        public DeliveryAddress Destination { get; set; }

        private string trackingStatus = "In Transit";

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

        public string GetTrackingStatus()
        {
            return trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                trackingStatus = newStatus;
            }
        }

        public abstract void PrintShipment();
    }
}