using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UsingCurdoperationEmployee.Data;
using UsingCurdoperationEmployee.Model;

namespace UsingCurdoperationEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationContext _dbcontex;
        public UserController(ApplicationContext dbcontex)
        {
            _dbcontex = dbcontex;
        }
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {

            return Ok(_dbcontex.Users.ToList());
        }
        [HttpPost]
        [Route("Save")]
        public IActionResult UserSave(Addusers user)
        {
            var saveusers = new User()
            {
                Usermail = user.Usermail,
                UserName = user.UserName,
                UserAge = user.UserAge,
                UserPassword = user.UserPassword,
                UserDob = user.UserDob

            };
            _dbcontex.Users.Add(saveusers);
            _dbcontex.SaveChanges();
            if (saveusers is null)
            {
                return NotFound();
            }
            return Ok(saveusers);
        }
        [HttpGet]
        [Route("id")]
        public async Task<IActionResult> GetAction(int id)
        {

            var Getiduser = await _dbcontex.Users.FindAsync(id);
            if (Getiduser is null)
            {
                return NotFound();
            }
            return Ok(Getiduser);

        }
    }
}


