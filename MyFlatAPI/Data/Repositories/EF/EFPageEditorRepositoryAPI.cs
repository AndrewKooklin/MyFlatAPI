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
        int number;
        List<TopMenuLinkNameModel> linkNames = new List<TopMenuLinkNameModel>();
        List<RandomPhraseModel> randomPhrases = new List<RandomPhraseModel>();

        public EFPageEditorRepositoryAPI(MyFlatAPIDBContext context)
        {
            _context = context;
        }

        public List<TopMenuLinkNameModel> GetTopMenuLinkNames()
        {
            linkNames = _context.LinkNames.ToList();
            return linkNames;
        }

        public List<RandomPhraseModel> GetRandomPhrases()
        {
            randomPhrases = _context.RandomPhrases.ToList();
            return randomPhrases;
        }

        public bool AddRandomPhrase(RandomPhraseModel phraseModel)
        {
            _context.RandomPhrases.Add(phraseModel);

            number = _context.SaveChanges();
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeRandomPhrase(RandomPhraseModel model)
        {
            RandomPhraseModel rpm = new RandomPhraseModel();

            rpm = _context.RandomPhrases.FirstOrDefault(p => p.Id == model.Id);

            rpm.Phrase = model.Phrase;

            number = _context.SaveChanges();

            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteRandomPhrase(int id)
        {
            _context.RandomPhrases.Remove(new RandomPhraseModel { Id = id });

            number = _context.SaveChanges();

            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public HomePagePlaceholderModel GetPlaceholders()
        //{
        //    var hphm = _context.HomePagePlaceholders.FirstOrDefault(p => p.Id == 3);

        //    return hphm;
        //}


        public HomePagePlaceholderModel GetHomePagePlaceholder()
        {
            var placeHolder = _context.HomePagePlaceholders.FirstOrDefault();

            placeHolder.LinkNames = GetTopMenuLinkNames();
            placeHolder.RandomPhrases = GetRandomPhrases();

            return placeHolder;
        }

        public bool ChangeNameLinkTopMenu(TopMenuLinkNameModel model)
        {
            TopMenuLinkNameModel linkName = new TopMenuLinkNameModel();
            linkName = _context.LinkNames.FirstOrDefault(l => l.Id == model.Id);

            linkName.LinkName = model.LinkName;

            number = _context.SaveChanges();

            if(number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeLeftCentralAreaText(HomePagePlaceholderModel model)
        {
            HomePagePlaceholderModel hphm = new HomePagePlaceholderModel();

            hphm = _context.HomePagePlaceholders.FirstOrDefault(m => m.Id == model.Id);

            hphm.LeftCentralAreaText = model.LeftCentralAreaText;

            number = _context.SaveChanges();

            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeMainImage(HomePagePlaceholderModel model)
        {
            HomePagePlaceholderModel hphm = new HomePagePlaceholderModel();

            hphm = _context.HomePagePlaceholders.FirstOrDefault(m => m.Id == model.Id);

            hphm.MainPicture = model.MainPicture;

            number = _context.SaveChanges();

            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeBottomAreaHeader(HomePagePlaceholderModel model)
        {
            HomePagePlaceholderModel hphm = new HomePagePlaceholderModel();

            hphm = _context.HomePagePlaceholders.FirstOrDefault(m => m.Id == model.Id);

            hphm.BottomAreaHeader = model.BottomAreaHeader;

            number = _context.SaveChanges();

            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeBottomAreaContent(HomePagePlaceholderModel model)
        {
            HomePagePlaceholderModel hphm = new HomePagePlaceholderModel();

            hphm = _context.HomePagePlaceholders.FirstOrDefault(m => m.Id == model.Id);

            hphm.BottomAreaContent = model.BottomAreaContent;

            number = _context.SaveChanges();

            if (number > 0)
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
