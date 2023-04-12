using Bank.Domain.Account;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Irepository.Account
{
    public interface IAccountRepository
    {

      public  Task<IEnumerable<AccountEntity>> GetAccounts();  //Used For View Page
        public Task<IEnumerable<AccountEntity>> GetBranches();  // Used for Dropdown bind in Branch
        public Task<IEnumerable<AccountEntity>> GetAccTypes();  // Used for Dropdown bind in AccountTypes
        public Task<AccountEntity> GetAccount(int id);  // Used for Edit button 
        public int AddAccount(AccountEntity acc);
        public int UpdateAccount(AccountEntity acc);
        public int DeleteAccount(int id);
    }
}
