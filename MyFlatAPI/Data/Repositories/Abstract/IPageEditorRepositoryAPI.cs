using MyFlatAPI.Data.Models.EditPages;
using MyFlatAPI.Data.Models.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Repositories.Abstract
{
    public interface IPageEditorRepositoryAPI
    {
        HomePagePlaceholderModel GetHomePagePlaceholder();

        List<TopMenuLinkNameModel> GetTopMenuLinkNames();

        bool ChangeNameLinkTopMenu(TopMenuLinkNameModel model);

        List<RandomPhraseModel> GetRandomPhrases();

        List<string> GetRandomPhraseNames();

        bool AddRandomPhrase(RandomPhraseModel model);

        bool ChangeRandomPhrase(RandomPhraseModel model);

        bool DeleteRandomPhrase(int id);

        bool ChangeLeftCentralAreaText(HomePagePlaceholderModel model);

        bool ChangeMainImage(HomePagePlaceholderModel model);

        bool ChangeBottomAreaHeader(HomePagePlaceholderModel model);

        bool ChangeBottomAreaContent(HomePagePlaceholderModel model);

        List<ProjectModel> GetProjectsFromDB();

        bool AddProjectToDB(ProjectModel model);

        ProjectModel GetProjectById(int id);

        bool ChangeProject(ProjectModel model);

        bool DeleteProjectById(int id);

        List<ServiceModel> GetServicesFromDB();

        bool AddServiceToDB(ServiceModel model);

        ServiceModel GetServiceById(int id);

        bool ChangeService(ServiceModel model);

        bool DeleteServiceById(int id);

        List<PostModel> GetPostsFromDB();

        bool AddPostToDB(PostModel model);

        PostModel GetPostById(int id);

        bool ChangePost(PostModel model);

        bool DeletePostById(int id);

        ContactModel GetContactsFromDB();

        List<SocialModel> GetSocialLinksFromDB();

        bool ChangeContacts(ContactModel model);

        bool AddSocialToDB(SocialModel model);

        bool ChangeSocial(SocialModel model);

        SocialModel GetSocialById(int id);

        bool DeleteSocialById(int id);

    }
}
