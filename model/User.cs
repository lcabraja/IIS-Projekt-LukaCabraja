using System;
using System.Collections.Generic;

namespace model
{
    public class User
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public List<Image> Images { get; set; }
        public override bool Equals(object obj)
        {
            if (obj != null && obj is User user)
            {
                return ID.Equals(user.ID);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode() + 1 * 42;
        }
        public override string ToString()
        {
            var s = Images.Count > 1 ? "s" : "";
            return $"@{ID} {Username} [{Images.Count} Image{s}]";
        }
    }
}
