using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Models.Rendering
{
    public class ServiceOrdersCountModel
    {
        public string ServiceName { get; set; }

        public int OrdersByServiceCount { get; set; }
    }
}
