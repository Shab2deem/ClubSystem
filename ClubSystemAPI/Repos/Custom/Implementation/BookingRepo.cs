using ClubSystemAPI.Context;
using ClubSystemAPI.Models;
using ClubSystemAPI.Repos.Custom.Interface;
using ClubSystemAPI.Repos.General.Implementation;

namespace ClubSystemAPI.Repos.Custom.Implementation
{
    public class BookingRepo : GeneralRepo<BookingModel>, IBookingRepo
    {
        public BookingRepo(MyContext context):base(context)
        {

        }
    }
}
