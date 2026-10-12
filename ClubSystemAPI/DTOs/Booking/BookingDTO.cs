using ClubSystemAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClubSystemAPI.DTOs.Booking
{
    public class BookingDTO
    {
       public int Id { get; set; }
         public DateTime BookingDate { get; set; }
         public TimeSpan StartTime { get; set; }
         public TimeSpan EndTime { get; set; }
         public int GroupSize { set; get; }
         public string Status { get; set; }
         
        
    }
}
