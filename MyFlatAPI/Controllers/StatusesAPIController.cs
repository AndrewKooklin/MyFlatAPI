using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;

namespace MyFlatAPI.Controllers
{
    public class StatusesAPIController : Controller
    {
        private DataManager _dataManager;

        public StatusesAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet]
        [Route("[controller]/GetStatusNames")]
        public List<string> GetStatusNames()
        {
            return _dataManager.Rendering.GetStatusNames();
        }
    }
}
