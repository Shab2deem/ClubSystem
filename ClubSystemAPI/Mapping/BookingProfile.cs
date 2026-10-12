using AutoMapper;
using ClubSystemAPI.DTOs.Booking;
using ClubSystemAPI.Models;

namespace ClubSystemAPI.Mapping
{
    public class BookingProfile:Profile
    {
        public BookingProfile()
        {
            CreateMap<BookingModel,BookingDTO>().ReverseMap();
            CreateMap<BookingModel, CreateBookingDTO>().ReverseMap();
        }
    }
}
