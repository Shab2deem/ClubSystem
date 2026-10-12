using ClubSystemAPI.Unit_Of_Work.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClubSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        IUOF UOF { get; set; }
        public BookingController(IUOF unitofwork) { 
        
            UOF = unitofwork;
        
        }

    }
}
