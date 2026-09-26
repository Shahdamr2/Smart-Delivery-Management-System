namespace Assignment09.Entities
{
    public abstract partial class Shipment
    {
        private string trackingStatus = "In Transit";

        public string GetTrackingStatus()
        {
            return trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus)
                && newStatus != trackingStatus)
            {
                trackingStatus = newStatus;

                OnTrackingStatusChanged(newStatus);
            }
        }

        partial void OnTrackingStatusChanged(string newStatus);
    }
}