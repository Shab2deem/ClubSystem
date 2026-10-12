using ClubSystemAPI.Context;
using ClubSystemAPI.Models;
using ClubSystemAPI.Repos.Custom.Interface;
using ClubSystemAPI.Repos.General.Implementation;

namespace ClubSystemAPI.Repos.Custom.Implementation
{
    public class FacilityRepo : GeneralRepo<FacilityModel>, IFacilityRepo
    {
        public FacilityRepo(MyContext context) : base(context)
        {
        }
    }
}
