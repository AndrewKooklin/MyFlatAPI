using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Models.Rendering
{
    public class SocialModel : BaseModel
    {
        public byte[] SocialImage { get; set; }

        public string SocialLink { get; set; }
    }
}
