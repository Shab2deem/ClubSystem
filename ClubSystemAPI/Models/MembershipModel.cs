using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubSystemAPI.Models
{
    public class MembershipModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required] public DateTime EndDate { get; set; }
        [Required] public decimal Price { get; set; }
        [Required] public string Status { get; set; }
        [ForeignKey(nameof(MemberId))] public int MemberId { get; set; }
        public MemberModel Member { get; set; }

    }
}
