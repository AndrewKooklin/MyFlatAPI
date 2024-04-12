using MyFlatAPI.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFlatAPI.Data
{
    public class DataManager
    {
        public IAccountRepositoryAPI Accounts { get; set; }

        public DataManager(IAccountRepositoryAPI accounts)
        {
            Accounts = accounts;
        }
    }
}
