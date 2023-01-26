using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPI.Dtos;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IUnitOfWork uow;

        public AccountController(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        // api/account/login

        [HttpPost("login")] 
        public async Task<IActionResult> Login(LoginReqDto loginReq)
        {
            var user = await uow.UserReposetory.Authenticate(loginReq.Username, loginReq.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            var loginRes = new LoginResDto();
            loginRes.Username = loginReq.Username;
            loginRes.Token = "Token will come here";
            return Ok(loginRes);
        }
    }
}
