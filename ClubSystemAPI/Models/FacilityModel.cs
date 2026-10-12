using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ClubSystemAPI.Models
{
    [Index(nameof(Name),IsUnique =true)]
    public class FacilityModel
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required,Range(1,100)] public int Capacity { get; set; }
        [Required,Range(50,1000)] public decimal HourlyPrice {  get; set; }   
        
    }
}
