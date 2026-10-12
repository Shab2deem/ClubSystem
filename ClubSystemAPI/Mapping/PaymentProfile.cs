using AutoMapper;
using ClubSystemAPI.DTOs.Payment;
using ClubSystemAPI.Models;

namespace ClubSystemAPI.Mapping
{
    public class PaymentProfile:Profile
    {
        public PaymentProfile()
        {
            CreateMap<PaymentModel,PaymentDTO>().ReverseMap();
            CreateMap<PaymentModel, CreatePaymentDTO>().ReverseMap();
        }
    }

    
}
