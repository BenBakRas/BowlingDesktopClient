namespace BowlingDesktopClient.Models
{
    public class Booking
    {
        public DateTime StartDateTime { get; set; }
        public int HoursToPlay { get; set; }
        public int NoOfPlayers { get; set; }
        public Customer? Customer { get; set; }

        // Empty constructor
        public Booking() { }

        // Constructor with parameters
        public Booking(DateTime startDateTime, int hoursToPlay, int noOfPlayers, Customer? cutomer)
        {
            StartDateTime = startDateTime;
            HoursToPlay = hoursToPlay;
            NoOfPlayers = noOfPlayers;
            Customer = cutomer;

        }

        public override string ToString()
        {
            string cusNavn = Customer.FirstName + " " + Customer.LastName;
            string text = "Start tid: " + StartDateTime + ". Spille Tid: " + HoursToPlay + ". Antal spillere: " + NoOfPlayers + ". Kundens navn: " + cusNavn;
            return text;
        }
    }
       
}

