using MyFlatAPI.Data.Models.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Repositories.Abstract
{
    public interface IRenderingRepositoryAPI
    {
        List<string> GetServiceNames();

        List<ServiceOrdersCountModel> GetServiceOrdersCount();

        Task<bool> SaveOrder(OrderModel order);
    }
}
