using MyFlatAPI.Data.Models.Rendering;
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

        public List<string> GetServiceNames()
        {
            List<string> names = new List<string>();

            foreach (var category in _context.Services)
            {
                names.Add(category.ServiceName);
            };

            return names;
        }

        public List<ServiceOrdersCountModel> GetServiceOrdersCount()
        {
            List<ServiceOrdersCountModel> serviceOrdersCounts = new List<ServiceOrdersCountModel>();

            ServiceOrdersCountModel serviceOrdersCountModel;

            List<string> serviceNames = GetServiceNames();

            foreach (var serviceName in serviceNames)
            {
                serviceOrdersCountModel = new ServiceOrdersCountModel
                {
                    ServiceName = serviceName,
                    OrdersCount = _context.Orders.Where(o => o.ServiceName == serviceName).Count()
                };
                serviceOrdersCounts.Add(serviceOrdersCountModel);
            }

            return serviceOrdersCounts;
        }
    }
}
