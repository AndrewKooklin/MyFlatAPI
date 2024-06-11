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

        [HttpPost("[controller]/AddSocialToDB/{SocialModel?}")]
        public bool AddSocialToDB([FromBody] SocialModel model)
        {
            return _dataManager.PageEditor.AddSocialToDB(model);
        }

        [HttpPost("[controller]/ChangeSocial/{SocialModel?}")]
        public bool ChangeSocial([FromBody] SocialModel model)
        {
            return _dataManager.PageEditor.ChangeSocial(model);
        }

        [HttpGet("[controller]/GetSocialById/{id?}")]
        public SocialModel GetSocialById(int id)
        {
            var project = _dataManager.PageEditor.GetSocialById(id);
            return project;
        }

        [HttpPost("[controller]/DeleteSocialById/{id?}")]
        public bool DeleteSocialById(int id)
        {
            return _dataManager.PageEditor.DeleteSocialById(id);
        }
    }
}
