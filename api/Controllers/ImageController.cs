using model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private List<User> users;

        public ImageController(List<User> users)
        {
            this.users = users;
        }

        [HttpGet]
        public List<Image> Get([FromQuery] string? userid)
        {
            var responsedata = userid != null ? users.Find(u => u.ID.Equals(userid)) : null;
            Response.StatusCode = userid == null ? 400 : (responsedata != null ? 200 : 404);
            return responsedata?.Images;

        }

        [HttpPost]
        public void Post(string userid, Image image)
        {
            var user = users.Find(u => u.ID == userid);
            if (user != null)
            {
                var index = user.Images.FindIndex(i => i.Equals(image));
                if (index != -1)
                {
                    user.Images[index] = image;
                }
                else
                {
                    user.Images.Add(image);
                }
                Response.StatusCode = 201;
            }
            else
            {
                Response.StatusCode = 404;
            }
        }

        [HttpDelete]
        public void Delete(string userid, Image image)
        {
            var user = users.Find(u => u.ID == userid);
            if (user != null)
            {
                var index = user.Images.FindIndex(i => i.Equals(image));
                if (index != -1)
                {
                    user.Images.Remove(image);
                    Response.StatusCode = 200;
                }
                else
                {
                    Response.StatusCode = 404;
                }
            }
            else
            {
                Response.StatusCode = 404;
            }

        }
    }
}
