using AutoMapper;
using ClubSystemAPI.DTOs.Membership;
using ClubSystemAPI.Models;

namespace ClubSystemAPI.Mapping
{
    public class MembershipProfile:Profile
    {
        public MembershipProfile()
        {
            CreateMap<MembershipModel, MembershipDTO>().ReverseMap();
            CreateMap<MembershipModel, CreateMembershipDTO>().ReverseMap();
        }
    }
}
