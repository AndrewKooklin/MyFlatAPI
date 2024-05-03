using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;
using MyFlatAPI.Data.Models.EditPages;

namespace MyFlatAPI.Controllers
{
    public class HomePageEditAPIController : Controller
    {
        private DataManager _dataManager;

        public HomePageEditAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public HomePagePlaceholderModel GetHomePagePlaceholder()
        {
            return _dataManager
        }
    }
}
