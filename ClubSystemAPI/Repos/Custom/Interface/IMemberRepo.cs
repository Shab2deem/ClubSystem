using ClubSystemAPI.Models;
using ClubSystemAPI.Repos.General.Interface;
using Microsoft.Identity.Client;

namespace ClubSystemAPI.Repos.Custom.Interface
{
    public interface IMemberRepo : IGeneralRepo<MemberModel>
    {
        
        public MemberModel GetMemberByName(string Name);
        public ICollection<MemberModel> GetActive();
        
    }
}
