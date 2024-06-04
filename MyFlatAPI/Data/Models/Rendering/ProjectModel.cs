using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Models.Rendering
{
    public class ProjectModel : BaseModel
    {
        public byte[] ProjectImage { get; set; }

        public string ProjectHeader { get; set; }

        public string ProjectDescription { get; set; }
    }
}
