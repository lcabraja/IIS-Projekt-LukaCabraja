using model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using api.Model;
using api.Auth;
using validator;
using System.Xml.Linq;

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

        private static readonly string RNG = "<element name=\"User\" xmlns=\"http://relaxng.org/ns/structure/1.0\" datatypeLibrary=\"http://www.w3.org/2001/XMLSchema-datatypes\" ns=\"http://schemas.datacontract.org/2004/07/model\"><element name=\"ID\"><text /></element><element name=\"Username\"><text /></element><element name=\"PasswordHash\"><text /></element><element name=\"Images\"><zeroOrMore><element name=\"Image\"><element name=\"ResourceTitle\"><text /></element><element name=\"ResourceURL\"><text /></element><element name=\"IsFavorite\"><text /></element></element></zeroOrMore></element></element>";
        private Validator _validator = new("", RNG);

        [HttpPost("rng")]
        public string ValidateRNG([FromBody] XElement xmldata)
        {
            _validator.SetInstance(xmldata.ToString());
            if (string.IsNullOrEmpty(_validator.FirstError))
            {
                Response.StatusCode = 400;
                return _validator.FirstError;
            }
            return null;
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
