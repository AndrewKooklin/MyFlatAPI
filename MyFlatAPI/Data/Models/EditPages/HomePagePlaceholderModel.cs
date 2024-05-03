using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Models.EditPages
{
    public class HomePagePlaceholderModel : BaseModel
    {
        [NotMapped]
        public List<TopMenuLinkNameModel> LinkNames { get; set; }

        [NotMapped]
        public List<RandomPhraseModel> RandomPhrases { get; set; }

        public string LeftCentralAreaText { get; set; }

        public byte[] MainPicture { get; set; }

        public string BottomAreaHeader { get; set; }

        public string BottomAreaContent { get; set; }
    }
}
