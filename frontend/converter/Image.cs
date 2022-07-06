using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Client
{
    public partial class Image
    {
        public static implicit operator model.Image(api.Client.Image image)
            => new()
            {
                ResourceTitle = image.ResourceTitle,
                ResourceURL = image.ResourceURL,
                IsFavorite = image.IsFavorite,
            };
    }
}
