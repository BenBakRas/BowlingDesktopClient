namespace BowlingDesktopClient.Models
{
    public class Price
    {
        public double? NormalPrice { get; set; }
        public double? SpecialPrice { get; set; }
        public string? Weekday { get; set; }

        // Empty constructor
        public Price() { }

        // Constructor with parameters
        public Price(double? normalPrice, double? specialPrice, string? weekday)
        {
            NormalPrice = normalPrice;
            SpecialPrice = specialPrice;
            Weekday = weekday;
        }

        public override string ToString()
        {
            string text = "Normal Pris: " + NormalPrice + ". Speciel Pris: " + SpecialPrice + ". Dag på ugen: " + Weekday;
            return text;
        }

    }
}
