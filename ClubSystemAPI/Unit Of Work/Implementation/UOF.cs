using ClubSystemAPI.Context;
using ClubSystemAPI.Models;
using ClubSystemAPI.Repos.Custom.Interface;
using ClubSystemAPI.Repos.General.Interface;
using ClubSystemAPI.Unit_Of_Work.Interface;

namespace ClubSystemAPI.Unit_Of_Work.Implementation
{
    public class UOF : IUOF
    {
        readonly MyContext context;
        public UOF(MyContext context, IBookingRepo ibr,IFacilityRepo ifr, IMemberRepo imr, IMembershipRepo imsr, IPaymentRepo ipr)
        {
            this.context = context;
            Bookings = ibr;
            Facilities=ifr;
            Members = imr;
            Memberships = imsr;
            Payments = ipr;
        }

     
        public IBookingRepo Bookings { get; set; }
        public IFacilityRepo Facilities { get; set; }

        public IMemberRepo Members {get;set;}

        public IMembershipRepo Memberships { get; set; }

        public IPaymentRepo Payments {get;set;}

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
