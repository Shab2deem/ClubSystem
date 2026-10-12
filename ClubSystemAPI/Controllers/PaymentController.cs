using ClubSystemAPI.Unit_Of_Work.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClubSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        IUOF UOF { get; set; }
        public PaymentController(IUOF unitofwork)
        {

            UOF = unitofwork;

        }
    }
}
