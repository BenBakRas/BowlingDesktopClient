namespace BowlingDesktopClient.Models
{
    public class Booking {


        public Booking(){}
        public Booking( int inId,DateTime inStartDateTime, int inHoursToPlay, int inBookingNumber, int inNoOfPlayers)
    {
            Id = inId;
        StartDateTime = inStartDateTime;
        HoursToPlay = inHoursToPlay;
        BookingNumber = inBookingNumber;
        NoOfPlayers = inNoOfPlayers;
    }
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public int HoursToPlay { get; set; }
        public int BookingNumber { get; set; }
        public int NoOfPlayers { get; set; }


    }
}
