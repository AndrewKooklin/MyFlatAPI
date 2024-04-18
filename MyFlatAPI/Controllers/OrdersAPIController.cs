using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;
using MyFlatAPI.Data.Models.Rendering;

namespace MyFlatAPI.Controllers
{
    public class OrdersAPIController : Controller
    {
        private DataManager _dataManager;

        public OrdersAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpPost("[controller]/SaveOrder/{OrderModel?}")]
        public bool SaveOrder([FromBody] OrderModel order)
        {
            return _dataManager.Rendering.SaveOrder(order).GetAwaiter().GetResult();
        }

        [HttpGet("[controller]/GetAllOrders")]
        public List<OrderModel> GetAllOrders()
        {
            return _dataManager.Rendering.GetAllOrders();
        }

        
    }
}
