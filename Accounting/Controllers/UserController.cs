using Accounting.Models;
using Accounting.UOW;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseApiController
    {
        public UserController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

     
       [HttpGet]
       public IActionResult Get()
        {
            var users=UnitOfWork.UserRepository.GetAll().ToList();
            return Ok(users);
        }
        

    }
}
