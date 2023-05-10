namespace BowlingDesktopClient.Models
{
    public class Price
    {
        public Price() { }
        public Price(int inId, double inNormalPrice, double inSpecialPrice, string inWeekday)
        {
            Id = inId;
            NormalPrice = inNormalPrice;
            SpecialPrice = inSpecialPrice;
            Weekday = inWeekday;
        }
        public int Id { get; set; }
        public double NormalPrice { get; set; }
        public double SpecialPrice { get; set; }
        public string Weekday { get; set; }

    }
}