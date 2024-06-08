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

        [HttpPost("[controller]/AddServiceToDB/{ServiceModel?}")]
        public bool AddServiceToDB([FromBody] ServiceModel model)
        {
            return _dataManager.PageEditor.AddServiceToDB(model);
        }

        [HttpGet("[controller]/GetServiceById/{id?}")]
        public ServiceModel GetServiceById(int id)
        {
            var service = _dataManager.PageEditor.GetServiceById(id);
            return service;
        }

        [HttpPost("[controller]/ChangeService/{ServiceModel?}")]
        public bool ChangeService([FromBody] ServiceModel model)
        {
            return _dataManager.PageEditor.ChangeService(model);
        }

        [HttpPost("[controller]/DeleteServiceById/{id?}")]
        public bool DeleteServiceById(int id)
        {
            return _dataManager.PageEditor.DeleteServiceById(id);
        }
    }
}
