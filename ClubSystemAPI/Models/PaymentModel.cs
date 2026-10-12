using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubSystemAPI.Models
{
    public class PaymentModel
    {
        [Key] public int Id { get; set; }
        [Required,Range(100,10000)] public decimal Amount { get; set; }
        [Required] public DateTime PaymentDate { get; set; }
        [Required] public string PaymentMethod { get; set; }
        [ForeignKey(nameof(MembershipId))] public int MembershipId { get; set; }
        public MembershipModel Membership { get; set; }
    }
}
