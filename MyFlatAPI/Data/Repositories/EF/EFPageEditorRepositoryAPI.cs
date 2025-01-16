using MyFlatAPI.Data.Models.EditPages;
using MyFlatAPI.Data.Models.Rendering;
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
        int number;

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

        public List<string> GetRandomPhraseNames()
        {
            List<string> pNames = new List<string>();
            var phraseNames = _context.RandomPhrases.ToArray();
            foreach (var item in phraseNames)
            {
                pNames.Add(item.Phrase);
            }
            return pNames;
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

            hphm = _context.HomePagePlaceholders.FirstOrDefault();

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

            hphm = _context.HomePagePlaceholders.FirstOrDefault();

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

            hphm = _context.HomePagePlaceholders.FirstOrDefault();

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

            hphm = _context.HomePagePlaceholders.FirstOrDefault();

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

        public List<ProjectModel> GetProjectsFromDB()
        {
            return _context.Projects.ToList();
        }

        public bool AddProjectToDB(ProjectModel model)
        {
            _context.Projects.Add(model);

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

        public ProjectModel GetProjectById(int id)
        {
            return _context.Projects.FirstOrDefault(p => p.Id == id);
        }

        public bool ChangeProject(ProjectModel model)
        {
            ProjectModel projectFromDB = new ProjectModel();

            projectFromDB = _context.Projects.FirstOrDefault(m => m.Id == model.Id);

            projectFromDB.ProjectHeader = model.ProjectHeader;
            projectFromDB.ProjectDescription = model.ProjectDescription;
            projectFromDB.ProjectImage = model.ProjectImage;

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

        public bool DeleteProjectById(int id)
        {
            _context.Projects.Remove(new ProjectModel { Id = id });

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

        public List<ServiceModel> GetServicesFromDB()
        {
            return _context.Services.ToList();
        }

        public bool AddServiceToDB(ServiceModel model)
        {
            _context.Services.Add(model);

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

        public ServiceModel GetServiceById(int id)
        {
            return _context.Services.FirstOrDefault(s => s.Id == id);
        }

        public bool ChangeService(ServiceModel model)
        {
            ServiceModel serviceFromDB = new ServiceModel();

            serviceFromDB = _context.Services.FirstOrDefault(m => m.Id == model.Id);

            serviceFromDB.ServiceName = model.ServiceName;
            serviceFromDB.ServiceDescription = model.ServiceDescription;

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

        public bool DeleteServiceById(int id)
        {
            _context.Services.Remove(new ServiceModel { Id = id });

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

        public List<PostModel> GetPostsFromDB()
        {
            return _context.Posts.ToList();
        }

        public bool AddPostToDB(PostModel model)
        {
            model.PostingDate = DateTime.Now;
            _context.Posts.Add(model);

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

        public PostModel GetPostById(int id)
        {
            return _context.Posts.FirstOrDefault(s => s.Id == id);
        }

        public bool ChangePost(PostModel model)
        {
            PostModel postFromDB = new PostModel();

            postFromDB = _context.Posts.FirstOrDefault(m => m.Id == model.Id);

            postFromDB.PostHeader = model.PostHeader;
            postFromDB.PostDescription = model.PostDescription;
            postFromDB.PostImage = model.PostImage;

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

        public bool DeletePostById(int id)
        {
            _context.Posts.Remove(new PostModel { Id = id });

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

        public ContactModel GetContactsFromDB()
        {
            return _context.Contacts.FirstOrDefault();
        }

        public List<SocialModel> GetSocialLinksFromDB()
        {
            return _context.SocialLinks.ToList();
        }

        public bool ChangeContacts(ContactModel model)
        {
            ContactModel cm = new ContactModel();

            cm = _context.Contacts.FirstOrDefault();

            cm.ContactAddress = model.ContactAddress;
            cm.ContactPhone = model.ContactPhone;
            cm.ContactEmail = model.ContactEmail;

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

        public bool AddSocialToDB(SocialModel model)
        {
            _context.SocialLinks.Add(model);

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

        public bool ChangeSocial(SocialModel model)
        {
            SocialModel sm = new SocialModel();

            sm = _context.SocialLinks.FirstOrDefault(s => s.Id == model.Id);

            sm.SocialLink = model.SocialLink;
            sm.SocialImage = model.SocialImage;

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

        public SocialModel GetSocialById(int id)
        {
            return _context.SocialLinks.FirstOrDefault(s => s.Id == id);
        }

        public bool DeleteSocialById(int id)
        {
            _context.SocialLinks.Remove(new SocialModel { Id = id });

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
