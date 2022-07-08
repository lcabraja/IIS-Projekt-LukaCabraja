using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace model
{
    [DataContract]
    public class User
    {
        [DataMember(Order = 0)]
        public string ID { get; set; }
        [DataMember(Order = 1)]
        public string Username { get; set; }
        [DataMember(Order = 2)]
        public string PasswordHash { get; set; }
        [DataMember(Order = 3)]
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
