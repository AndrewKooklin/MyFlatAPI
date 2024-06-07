using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;
using MyFlatAPI.Data.Models.Rendering;

namespace MyFlatAPI.Controllers
{
    public class ServicesPageEditAPIController : Controller
    {
        private DataManager _dataManager;

        public ServicesPageEditAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet("[controller]/GetServicesFromDB")]
        public List<ServiceModel> GetServicesFromDB()
        {
            return _dataManager.PageEditor.GetServicesFromDB();
        }
    }
}
