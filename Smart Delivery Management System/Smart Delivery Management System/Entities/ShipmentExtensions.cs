using Assignment09.Entities;
using Assignment09.Inheritance;

namespace Assignment09.Extensions
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string shipmentType = "Shipment";

            if (shipment is StandardShipment)
            {
                shipmentType = "Standard";
            }
            else if (shipment is ExpressShipment)
            {
                shipmentType = "Express";
            }
            else if (shipment is InternationalShipment)
            {
                shipmentType = "International";
            }

            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} KG | {shipment.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetTrackingStatus() == "Delivered";
        }
    }
}