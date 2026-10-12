using System.ComponentModel.DataAnnotations;

namespace ClubSystemAPI.Models
{
    public class MemberModel
    {
        [Key]
        public int Id { get; set; }
        [Required,MinLength(3),MaxLength(100)]
        public string FullName { get; set; }
        [Required,EmailAddress]
        public string Email {  get; set; }
        [Required,Phone]
        public string Phone { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public ICollection<BookingModel> Bookings { get; set; }
        public MembershipModel Membership { get; set; }
    }
}
