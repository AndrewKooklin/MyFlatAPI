﻿using MyFlatAPI.Data.Models.EditPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data.Repositories.Abstract
{
    public interface IPageEditorRepositoryAPI
    {
        HomePagePlaceholderModel GetHomePagePlaceholder();

        bool ChangeNameLinkTopMenu(TopMenuLinkNameModel model);

        bool AddRandomPhrase(RandomPhraseModel model);

        bool ChangeRandomPhrase(RandomPhraseModel model);

        bool DeleteRandomPhrase(int id);

        bool ChangeLeftCentralAreaText(HomePagePlaceholderModel model);

        bool ChangeMainImage(HomePagePlaceholderModel model);

        bool ChangeBottomAreaHeader(HomePagePlaceholderModel model);

        bool ChangeBottomAreaContent(HomePagePlaceholderModel model);
    }
}