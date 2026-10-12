using ClubSystemAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace ClubSystemAPI.DTOs.Member
{
    public class CreateMemberDTO
    {
        
        public string FullName { get; set; }
        
        public string Email { get; set; }
        
        public string Phone { get; set; }
        
        public DateTime BirthDate { get; set; }
        
    }
}