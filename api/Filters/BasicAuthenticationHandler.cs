using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text;
using System;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;
using model;

namespace api.Filters
{
    public class BasicAuthenticationHandler :
        AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly List<User> users;
        public List<string> Users
        {
            get
            {
                return users.Select(u => $"{u.Username}:{u.PasswordHash}").ToList();
            }
        }

        public BasicAuthenticationHandler(List<User> users, IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
            this.users = users;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (Request.Headers.ContainsKey("Authorization") == false)
            {
                return AuthenticateResult.Fail("Nedostaju podaci!");
            }

            try
            {
                AuthenticationHeaderValue headerValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]); //Basic 982hfoaeihdnajsodai
                string data = headerValue.Parameter; //982hfoaeihdnajsodai
                string decodedData = Encoding.UTF8.GetString(Convert.FromBase64String(data)); //ime:lozinka
                string[] userData = decodedData.Split(':');

                bool ok = false;

                foreach (string user in Users)
                {
                    string[] userSplit = user.Split(':');

                    if (userSplit[0] == userData[0] && userSplit[1] == userData[1])
                    {
                        ok = true;
                    }
                }

                if (ok)
                {
                    Claim[] claims = new Claim[]
                    {
                        new Claim(ClaimTypes.Name, userData[0])
                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    AuthenticationTicket ticket = new AuthenticationTicket(claimsPrincipal, Scheme.Name);
                    return AuthenticateResult.Success(ticket);
                }
                else
                {
                    return AuthenticateResult.Fail("Wrong username or password!");
                }
            }
            catch
            {
                return AuthenticateResult.Fail("Bad data format!");
            }
        }
    }
}
