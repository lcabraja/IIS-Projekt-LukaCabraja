using model;
using System.Collections.Generic;

namespace api.Auth
{
    public interface IJwtAuth
    {
        string Authentication(string username, string password, List<User> users);
    }
}
