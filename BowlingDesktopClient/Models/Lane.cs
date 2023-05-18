namespace BowlingDesktopClient.Models
{
    public class Lane
    {
        public int Id { get; set; }
        public int? LaneNumber { get; set; }

        // Empty Constructor
        public Lane() { }

        // Constructor with LaneNumber parameter
        public Lane(int? inLaneNumber)
        {
            LaneNumber = inLaneNumber;
        }

        public override string ToString()
        {
            string text = "Bane nummer: " + LaneNumber;
            return text;
        }

    }
}
