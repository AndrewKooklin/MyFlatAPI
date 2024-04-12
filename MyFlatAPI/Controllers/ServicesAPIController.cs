using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;

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
        [Route("[controller]/{GetCategoryNames}")]
        public List<string> GetCategoryNames()
        {
            return _dataManager.Rendering.GetCategoryNames();
        }
    }
}
