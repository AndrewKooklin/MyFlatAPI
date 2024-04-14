using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MyFlatAPI.Data.Models;

namespace MyFlatAPI.Data.Models.Rendering
{
    public class CategoryServiceModel : BaseModel
    {
        [Required]
        [MinLength(3, ErrorMessage = "Имя категории не менее 3 символов")]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }
    }
}
