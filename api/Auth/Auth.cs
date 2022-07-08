﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using model;
using System.Collections.Generic;

namespace api.Auth
{
    public class Auth : IJwtAuth
    {
        private readonly string key;
        public Auth(string key)
        {
            this.key = key;
        }

        public string Authentication(string username, string password, List<User> users)
        {
            bool foundMatch = false;
            foreach (var user in users)
            {
                if (user.Username.Equals(username) && user.PasswordHash.Equals(password))
                {
                    foundMatch = true;
                }
            }
            if (!foundMatch)
            {
                return null;
            }

            // 1. Create Security Token Handler
            var tokenHandler = new JwtSecurityTokenHandler();

            // 2. Create Private Key to Encrypted
            var tokenKey = Encoding.ASCII.GetBytes(key);

            //3. Create JETdescriptor
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, username)
                    }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            //4. Create Token
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // 5. Return Token from method
            return tokenHandler.WriteToken(token);
        }
    }
}