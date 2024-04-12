using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Models
{
    public class CategoryServiceModel : BaseModel
    {
        [Required]
        [MinLength(3, ErrorMessage = "Имя категории не менее 3 символов")]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }
    }
}
