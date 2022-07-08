using model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using api.Model;
using api.Auth;

namespace api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private List<User> users;
        private readonly IJwtAuth jwtAuth;

        public UserController(List<User> users, IJwtAuth jwtAuth)
        {
            this.users = users;
            this.jwtAuth = jwtAuth;
        }

        [HttpGet]
        public List<User> Get() 
            => users.GetRange(0, System.Math.Min(50, users.Count));

        [AllowAnonymous]
        [HttpGet("{userid}")]
        public User Get(string userid) 
            => users.Find(u => u.ID.Equals(userid));

        [HttpPost]
        public void Post(User user)
        {
            var index = users.FindIndex(u => u.Equals(user));
            if (index != -1)
            {
                users[index] = user;
                Response.StatusCode = 200;
            }
            else
            {
                users.Add(user);
                Response.StatusCode = 201;
            }
        }

        [HttpDelete]
        public void Delete(string userid)
        {
            var user = users.Find(u => u.ID == userid);
            if (user != null)
            {
                users.Remove(user);
                Response.StatusCode = 200;
            }
            else
            {
                Response.StatusCode = 404;
            }
        }

        [AllowAnonymous]
        [HttpPost("authentication")]
        public IActionResult Authentication([FromBody] UserCredential userCredential)
        {
            var token = jwtAuth.Authentication(userCredential.Username, userCredential.Password, users);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
    }
}
