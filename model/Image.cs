using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    [DataContract]
    public class Image
    {
        [DataMember(Order = 0)]
        public string ResourceTitle { get; set; }
        [DataMember(Order = 1)]
        public string ResourceURL { get; set; }
        [DataMember(Order = 2)]
        public bool IsFavorite { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Image image)
            {
                return ResourceURL.Equals(image.ResourceURL);
            }
            return false;
        }

        public override int GetHashCode() 
            => ResourceURL.GetHashCode() * 42;

        public override string ToString() 
            => $"{ResourceTitle} [{ResourceURL}]";
    }
}
