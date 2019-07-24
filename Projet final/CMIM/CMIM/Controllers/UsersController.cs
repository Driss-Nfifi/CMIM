using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CMIM.Models;
using CMIM.Services;

namespace WebApi.Controllers
{
  [Authorize(Roles ="Admin")]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private readonly CmimDBContext _context;
        public UsersController(IUserService userService, CmimDBContext context)
        {

            _userService = userService;
            _context = context;
            //if(_context.Users.)
            var user = new User
            {

                FirstName = "dfé",
                LastName = "sqa",
                Username = "driss",
                Email = "drissnfifi@gmail.com",
                Password = "123456",
                Role = Role.Admin


            };

           
            var user1 = new User
            {

                FirstName = "dfé",
                LastName = "sqa",
                Username = "driss1",
                Email = "drissnfifi1@gmail.com",
                Password = "123456",
                Role = Role.User
            };

            _context.Users.Add(user);
            _context.Users.Add(user1);
            _context.SaveChangesAsync();
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User userParam)
        {
            var user = _userService.Authenticate(userParam.Username, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users =  _userService.GetAll();
            return Ok(users);
        }
    }
}