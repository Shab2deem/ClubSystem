using ClubSystemAPI.DTOs.Member;
using ClubSystemAPI.Unit_Of_Work.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace ClubSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        IUOF UOF { get; set; }
        public MemberController(IUOF unitofwork)
        {

            UOF = unitofwork;

        }
        [HttpGet]
        public IActionResult Get(int pageNum,int pageSize,string?name) {
            if (name == null)
            {
                return Ok(UOF.Members.GetAll().Skip(pageNum - 1 * pageSize)
                .Take(pageSize));
            }
            else
            {
                return Ok(UOF.Members.GetMemberByName(name));
            }

        }
        [HttpPost]
        public IActionResult Create(CreateMemberDTO memberDTO)
        {
            return Ok();
        }

       
    }
}
