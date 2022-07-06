using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Client
{
    public partial class User
    {
        public static implicit operator model.User(api.Client.User user) 
            => new()
            {
                ID = user.Id,
                Username = user.Username,
                PasswordHash = user.PasswordHash,
                Images = user.Images.ToList().Select(image => (model.Image)image).ToList()
            };
    }
}
