using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Models.Rendering
{
    public class OrderModel
    {
        [Key]
        [Required]
        public string OrderId { get; set; }

        [Required]
        public DateTime DateCreate { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Mobile { get; set; }

        [Required]
        [MinLength(5)]
        public string Message { get; set; }

        [Required]
        public string ServiceName { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> ServiceNames { get; set; }

        [Required]
        public string StatusName { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> StatusNames { get; set; }
    }
}
