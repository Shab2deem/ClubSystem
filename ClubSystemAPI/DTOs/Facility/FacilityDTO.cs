using System.ComponentModel.DataAnnotations;

namespace ClubSystemAPI.DTOs.Facility
{
    public class FacilityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public decimal HourlyPrice { get; set; }
    }
}
