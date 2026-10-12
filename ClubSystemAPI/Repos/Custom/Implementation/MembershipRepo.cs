using ClubSystemAPI.Context;
using ClubSystemAPI.Models;
using ClubSystemAPI.Repos.Custom.Interface;
using ClubSystemAPI.Repos.General.Implementation;

namespace ClubSystemAPI.Repos.Custom.Implementation
{
    public class MembershipRepo : GeneralRepo<MembershipModel>, IMembershipRepo
    {
        public MembershipRepo(MyContext context) : base(context)
        {
        }
    }
}
