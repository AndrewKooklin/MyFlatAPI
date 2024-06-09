using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;

namespace MyFlatAPI.Controllers
{
    public class ContactsPageEditAPIController : Controller
    {
        private DataManager _dataManager;

        public ContactsPageEditAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }


    }
}
