using MyFlatAPI.Data.Repositories.Abstract;

namespace MyFlatAPI.Data
{
    public class DataManager
    {
        public IAccountRepositoryAPI Accounts { get; set; }

        public IRenderingRepositoryAPI Rendering { get; set; }

        public IPageEditorRepositoryAPI PageEditor { get; set; }

        public DataManager(IAccountRepositoryAPI accounts,
                           IRenderingRepositoryAPI rendering,
                           IPageEditorRepositoryAPI pageEditor)
        {
            Accounts = accounts;
            Rendering = rendering;
            PageEditor = pageEditor;
        }
    }
}
