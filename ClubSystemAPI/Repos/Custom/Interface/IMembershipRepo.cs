using ClubSystemAPI.Models;
using ClubSystemAPI.Repos.General.Interface;

namespace ClubSystemAPI.Repos.Custom.Interface
{
    public interface IMembershipRepo : IGeneralRepo<MembershipModel>
    {
        public void Renew(int id);
    }
}
