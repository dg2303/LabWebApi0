using LabWebAPI0.Contracts.Data;
using LabWebAPI0.Contracts.Data.Entities;
using Microsoft.AspNetCore.Mvc;


namespace LabWebApi0.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private IRepository<User> _userRepository;
        public UserController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

       
        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();
            return Ok();
        }
    }
}
