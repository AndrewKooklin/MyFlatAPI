using MyFlatAPI.Data.Models.EditPages;
using MyFlatAPI.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Repositories.EF
{
    public class EFPageEditorRepositoryAPI : IPageEditorRepositoryAPI
    {
        private readonly MyFlatAPIDBContext _context;
        private int countBeforeAdded;
        private int countAfterAdded;

        public EFPageEditorRepositoryAPI(MyFlatAPIDBContext context)
        {
            _context = context;
        }


        public List<TopMenuLinkNameModel> GetTopMenuLinkNames()
        {
            return _context.LinkNames.ToList();
        }

        public List<RandomPhraseModel> GetRandomPhrases()
        {
            return _context.RandomPhrases.ToList();
        }

        public HomePagePlaceholderModel GetPlaceholders()
        {
            HomePagePlaceholderModel hphm = new HomePagePlaceholderModel();
            var ph = _context.HomePagePlaceholders.ToArray();
            hphm = ph[0];

            return hphm;
        }


        public HomePagePlaceholderModel GetHomePagePlaceholder()
        {
            HomePagePlaceholderModel hpm = new HomePagePlaceholderModel();

            hpm.LinkNames = GetTopMenuLinkNames();
            hpm.RandomPhrases = GetRandomPhrases();
            var placeHolders = GetPlaceholders();
            hpm.LeftCentralAreaText = placeHolders.LeftCentralAreaText;
            hpm.BottomAreaHeader = placeHolders.BottomAreaHeader;
            hpm.BottomAreaContent = placeHolders.BottomAreaContent;

            return hpm;
        }

        public bool ChangeNameLinkTopMenu(TopMenuLinkNameModel model)
        {
            TopMenuLinkNameModel linkName = new TopMenuLinkNameModel();
            linkName = _context.LinkNames.FirstOrDefault(l => l.Id == model.Id);

            linkName.LinkName = model.LinkName;

            var number = _context.SaveChanges();

            if(number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
