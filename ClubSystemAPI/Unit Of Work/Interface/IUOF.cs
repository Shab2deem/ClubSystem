using ClubSystemAPI.Models;
using ClubSystemAPI.Repos.Custom.Interface;
using ClubSystemAPI.Repos.General.Interface;

namespace ClubSystemAPI.Unit_Of_Work.Interface
{
    public interface IUOF
    {
        public IBookingRepo Bookings { get; }
        public IFacilityRepo Facilities { get; }
        public IMemberRepo Members { get; }
        public IMembershipRepo Memberships { get; }
        public IPaymentRepo Payments { get; }
        public void SaveChanges();

    }
}
