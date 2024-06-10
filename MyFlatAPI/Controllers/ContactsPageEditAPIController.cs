using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;
using MyFlatAPI.Data.Models.Rendering;

namespace MyFlatAPI.Controllers
{
    public class ContactsPageEditAPIController : Controller
    {
        private DataManager _dataManager;

        public ContactsPageEditAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet("[controller]/GetContactsFromDB")]
        public ContactModel GetContactsFromDB()
        {
            return _dataManager.PageEditor.GetContactsFromDB();
        }

        [HttpGet("[controller]/GetSocialLinksFromDB")]
        public List<SocialModel> GetSocialLinksFromDB()
        {
            return _dataManager.PageEditor.GetSocialLinksFromDB();
        }

        [HttpPost("[controller]/ChangeContacts/{ContactModel?}")]
        public bool ChangeContacts([FromBody] ContactModel model)
        {
            return _dataManager.PageEditor.ChangeContacts(model);
        }
    }
}
