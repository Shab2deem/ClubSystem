namespace ClubSystemAPI.DTOs.Booking
{
    public class CreateBookingDTO
    {
       
        public DateTime BookingDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int GroupSize { set; get; }
        public string Status { get; set; }

    }
}
