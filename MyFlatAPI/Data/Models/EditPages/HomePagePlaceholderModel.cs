using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Models.EditPages
{
    public class HomePagePlaceholderModel : BaseModel
    {
        public string LeftCentralAreaText { get; set; }

        public byte[] MainPicture { get; set; }

        public string BottomAreaHeader { get; set; }

        public string BottomAreaContent { get; set; }
    }
}
