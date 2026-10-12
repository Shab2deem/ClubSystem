using ClubSystemAPI.Context;
using ClubSystemAPI.Models;
using ClubSystemAPI.Repos.Custom.Interface;
using ClubSystemAPI.Repos.General.Implementation;

namespace ClubSystemAPI.Repos.Custom.Implementation
{
    public class MemberRepo : GeneralRepo<MemberModel>, IMemberRepo
    {
        public MemberRepo(MyContext context) : base(context)
        {
        }
    }
}
