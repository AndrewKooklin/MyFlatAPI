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

        [HttpGet("[controller]/GetTopMenuLinkNames")]
        public List<TopMenuLinkNameModel> GetTopMenuLinkNames()
        {
            return _dataManager.PageEditor.GetTopMenuLinkNames();
        }

        [HttpGet("[controller]/GetRandomPhrases")]
        public List<RandomPhraseModel> GetRandomPhrases()
        {
            return _dataManager.PageEditor.GetRandomPhrases();
        }

        [HttpGet("[controller]/GetRandomPhraseNames")]
        public List<string> GetRandomPhraseNames()
        {
            return _dataManager.PageEditor.GetRandomPhraseNames();
        }

        [HttpPost("[controller]/ChangeNameLinkTopMenu/{TopMenuLinkNameModel?}")]
        public bool ChangeNameLinkTopMenu([FromBody] TopMenuLinkNameModel model)
        {
            return _dataManager.PageEditor.ChangeNameLinkTopMenu(model);
        }

        [HttpPost("[controller]/AddRandomPhrase/{RandomPhraseModel?}")]
        public bool AddRandomPhrase([FromBody] RandomPhraseModel model)
        {
            return _dataManager.PageEditor.AddRandomPhrase(model);
        }

        [HttpPost("[controller]/ChangeRandomPhrase/{RandomPhraseModel?}")]
        public bool ChangeRandomPhrase([FromBody] RandomPhraseModel model)
        {
            return _dataManager.PageEditor.ChangeRandomPhrase(model);
        }

        [HttpPost("[controller]/DeleteRandomPhrase/{id?}")]
        public bool DeleteRandomPhrase(int id)
        {
            return _dataManager.PageEditor.DeleteRandomPhrase(id);
        }

        [HttpPost("[controller]/ChangeLeftCentralAreaText/{HomePagePlaceholderModel?}")]
        public bool ChangeLeftCentralAreaText([FromBody] HomePagePlaceholderModel model)
        {
            return _dataManager.PageEditor.ChangeLeftCentralAreaText(model);
        }

        [HttpPost("[controller]/ChangeMainImage/{HomePagePlaceholderModel?}")]
        public bool ChangeMainImage([FromBody] HomePagePlaceholderModel model)
        {
            return _dataManager.PageEditor.ChangeMainImage(model);
        }

        [HttpPost("[controller]/ChangeBottomAreaHeader/{HomePagePlaceholderModel?}")]
        public bool ChangeBottomAreaHeader([FromBody] HomePagePlaceholderModel model)
        {
            return _dataManager.PageEditor.ChangeBottomAreaHeader(model);
        }

        [HttpPost("[controller]/ChangeBottomAreaContent/{HomePagePlaceholderModel?}")]
        public bool ChangeBottomAreaContent([FromBody] HomePagePlaceholderModel model)
        {
            return _dataManager.PageEditor.ChangeBottomAreaContent(model);
        }
    }
}
