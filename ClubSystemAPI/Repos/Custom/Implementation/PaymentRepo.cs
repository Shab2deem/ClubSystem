using ClubSystemAPI.Context;
using ClubSystemAPI.Models;
using ClubSystemAPI.Repos.Custom.Interface;
using ClubSystemAPI.Repos.General.Implementation;

namespace ClubSystemAPI.Repos.Custom.Implementation
{
    public class PaymentRepo : GeneralRepo<PaymentModel>, IPaymentRepo
    {
        public PaymentRepo(MyContext context) : base(context)
        {
        }
    }
}
