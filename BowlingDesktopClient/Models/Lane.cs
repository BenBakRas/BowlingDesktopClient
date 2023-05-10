namespace BowlingDesktopClient.Models
{
    public class Lane
    {
        public Lane() { }
        public Lane(int? laneNumber) 
        { 
            LaneNumber = laneNumber;
        }
        public int? LaneNumber { get; set; }
    }
}
