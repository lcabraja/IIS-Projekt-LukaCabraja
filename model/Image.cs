using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Image
    {
        public string ResourceTitle { get; set; }
        public string ResourceURL { get; set; }
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
