using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Models.Rendering
{
    public class StatusModel : BaseModel
    {
        [Required]
        [MinLength(3)]
        public string StatusName { get; set; }
    }
}
