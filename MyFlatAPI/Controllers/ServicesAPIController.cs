using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;
using MyFlatAPI.Data.Models.Rendering;

namespace MyFlatAPI.Controllers
{
    public class ServicesAPIController : Controller
    {
        private DataManager _dataManager;

        public ServicesAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet]
        [Route("[controller]/{GetServiceNames}")]
        public List<string> GetServiceNames()
        {
            return _dataManager.Rendering.GetServiceNames();
        }

        [HttpGet]
        [Route("[controller]/{GetServiceOrdersCount}")]
        public List<ServiceOrdersCountModel> GetServiceOrdersCount()
        {
            return _dataManager.Rendering.GetServiceOrdersCount();
        }
    }
}
