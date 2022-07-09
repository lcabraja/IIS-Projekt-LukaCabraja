using model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using api.Model;
using api.Auth;
using validator;
using System.Xml.Linq;
using System.Xml.Schema;
using System;
using System.Xml;
using System.IO;
using RabbitMQ.Client;

namespace api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IModel rabbitChannel;
        private List<User> users;
        private readonly IJwtAuth jwtAuth;

        public UserController(IModel rabbitChannel, List<User> users, IJwtAuth jwtAuth)
        {
            this.rabbitChannel = rabbitChannel;
            this.users = users;
            this.jwtAuth = jwtAuth;

            SetupXsdValidator();
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
            AddOrUpdateUser(user);
        }

        private readonly Validator _validator = new("", model.User.RNG);

        [HttpPost("rng")]
        public string ValidateAgainstRNG([FromBody] XElement xmldata)
        {
            _validator.SetInstance(xmldata.ToString());
            if (string.IsNullOrEmpty(_validator.FirstError))
            {
                AddOrUpdateUser(UserFromXML(xmldata));
                return null;
            }
            Response.StatusCode = 400;
            return _validator.FirstError;
        }

        private XmlSchemaSet schemas = new XmlSchemaSet();

        [HttpPost("xsd")]
        public string ValidateAgainstXSD([FromBody] XElement xmldata)
        {
            XDocument xmldoc = new XDocument(xmldata);

            bool hasErrors = false;
            string errorMessage = "";
            xmldoc.Validate(schemas, (o, e) =>
            {
                errorMessage = e.Message;
                hasErrors = true;
            });

            if (!hasErrors)
            {
                AddOrUpdateUser(UserFromXML(xmldata));
                return null;
            }
            Response.StatusCode = 400;
            return errorMessage;
        }

        private void SetupXsdValidator()
        {
            schemas.Add("http://schemas.datacontract.org/2004/07/model", XmlReader.Create(new StringReader(model.User.XSD)));
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

        private static User UserFromXML(XElement xmldata)
        {
            while (xmldata.HasAttributes)
            {
                xmldata.RemoveAttributes();
            }
            User user = Deserializer.Deserialize<User>(xmldata.ToString().Replace("xmlns=\"http://schemas.datacontract.org/2004/07/model\"", ""));
            return user;
        }

        private void AddOrUpdateUser(User user)
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
            RabbitClient.SendMessage(rabbitChannel, user);
        }
    }
}
