namespace SeattleBikeShare.Library.DataModel
{
    public class BikeStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int BikesAvailable { get; set; }

        public int ParkingSpotsAvailable
        {
            get { return this.Capacity - this.BikesAvailable; }
        }
    }
}