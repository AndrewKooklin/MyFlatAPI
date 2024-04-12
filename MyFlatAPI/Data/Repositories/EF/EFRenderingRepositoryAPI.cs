using MyFlatAPI.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Repositories.EF
{
    public class EFRenderingRepositoryAPI : IRenderingRepositoryAPI
    {
        private readonly MyFlatAPIDBContext _context;

        public EFRenderingRepositoryAPI(MyFlatAPIDBContext context)
        {
            _context = context;
        }

        public List<string> GetCategoryNames()
        {
            List<string> names = new List<string>();

            foreach (var category in _context.CategoryService)
            {
                names.Add(category.CategoryName);
            };

            return names;
        }
    }
}
