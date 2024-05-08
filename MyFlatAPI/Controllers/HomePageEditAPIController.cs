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

        [HttpGet("[controller]/GetHomePagePlaceholder")]
        public HomePagePlaceholderModel GetHomePagePlaceholder()
        {
            return _dataManager.PageEditor.GetHomePagePlaceholder();
        }

        [HttpPost("[controller]/ChangeNameLinkTopMenu/{TopMenuLinkNameModel?}")]
        public bool ChangeNameLinkTopMenu([FromBody] TopMenuLinkNameModel model)
        {
            return _dataManager.PageEditor.ChangeNameLinkTopMenu(model);
        }
    }
}
