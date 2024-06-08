using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Models.Rendering
{
    public class PostModel : BaseModel
    {
        public byte[] PostImage { get; set; }

        public DateTime PostingDate { get; set; }

        public string PostHeader { get; set; }

        public string PostDescription { get; set; }
    }
}
