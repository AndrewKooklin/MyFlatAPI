using MyFlatAPI.Data.Models.Rendering;
using MyFlatAPI.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace MyFlatAPI.Data.Repositories.EF
{
    public class EFRenderingRepositoryAPI : IRenderingRepositoryAPI
    {
        private readonly MyFlatAPIDBContext _context;
        private int countBeforeAdded;
        private int countAfterAdded;

        public EFRenderingRepositoryAPI(MyFlatAPIDBContext context)
        {
            _context = context;
        }

        public List<OrderModel> GetAllOrders()
        {
            return _context.Orders.ToList();
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

        public List<string> GetStatusNames()
        {
            List<string> names = new List<string>();

            foreach (var category in _context.Statuses)
            {
                names.Add(category.StatusName);
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

        public async Task<bool> SaveOrder(OrderModel order)
        {
            countBeforeAdded = await _context.Orders.CountAsync();

            if (order.Id == default)
            {
                //_context.Entry(phoneBookRecord).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                await _context.Orders.AddAsync(order);
            }
            _context.SaveChanges();

            countAfterAdded = await _context.Orders.CountAsync();
            if (countAfterAdded > countBeforeAdded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public OrderModel GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.Id == id);
        }

        public void ChangeStatusOrder(ChangeStatusModel changeStatusModel)
        {
            OrderModel orderModel = new OrderModel();
            orderModel = GetOrderById(changeStatusModel.Id);

            orderModel.StatusName = changeStatusModel.Status;

            _context.Entry(orderModel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.Orders.Update(orderModel);
            _context.SaveChanges();
        }
    }
}
