using ClubSystemAPI.Models;
using ClubSystemAPI.Repos.General.Interface;

namespace ClubSystemAPI.Repos.Custom.Interface
{
    public interface IPaymentRepo:IGeneralRepo<PaymentModel>
    {
        public ICollection<PaymentModel> GetPaymentStatistics();
    }
}
