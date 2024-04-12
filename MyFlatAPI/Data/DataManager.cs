using MyFlatAPI.Data.Repositories.Abstract;

namespace MyFlatAPI.Data
{
    public class DataManager
    {
        public IAccountRepositoryAPI Accounts { get; set; }

        public IRenderingRepositoryAPI Rendering { get; set; }

        public DataManager(IAccountRepositoryAPI accounts,
                           IRenderingRepositoryAPI rendering)
        {
            Accounts = accounts;
            Rendering = rendering;
        }
    }
}
