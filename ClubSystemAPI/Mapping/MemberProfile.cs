using AutoMapper;
using ClubSystemAPI.DTOs.Member;
using ClubSystemAPI.Models;

namespace ClubSystemAPI.Mapping
{
    public class MemberProfile:Profile
    {
        public MemberProfile()
        {
            CreateMap<MemberModel, MemberDTO>().ReverseMap();
            CreateMap<MemberModel, CreateMemberDTO>().ReverseMap();

        }
    }

}
