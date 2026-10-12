using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubSystemAPI.Models
{
    public class BookingModel
    {
        [Key] public int Id { get; set; }
        [Required] public DateTime BookingDate { get; set; }
        [Required] public TimeSpan StartTime { get; set; }
        [Required] public TimeSpan EndTime { get; set; }
        [Required] public int GroupSize { set; get; }
        [Required] public string Status { get; set; }
        [Required, ForeignKey(nameof(MemberId))]public int MemberId  { get;set;}
        public MemberModel Member { get; set; }
        [ForeignKey(nameof(FacilityId))] public int FacilityId {  get; set; }
        public FacilityModel Facility { get; set; }
    }
}
