using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Models.EditPages
{
    public class RandomPhraseModel : BaseModel
    {
        public string Phrase { get; set; }

        [NotMapped]
        public string InputChangePhraseError { get; set; }
    }
}
