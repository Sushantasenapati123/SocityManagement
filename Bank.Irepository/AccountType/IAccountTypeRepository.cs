using Bank.Domain.AccountType;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Bank.Domain.Customer.CustmerEntity;

namespace Bank.Irepository.AccountType
{
    public interface IAccountTypeRepository
    {
        Task<IEnumerable<AccountTypeModel>> getaccount();
        Task<AccountTypeModel> Getaccount(int id);
        Task<IEnumerable<AccountTypeModel>> GetGIGroupCode();
        int accountAdd(AccountTypeModel at);
        int Updateaccount(AccountTypeModel at);
        int Deleteaccount(int id);
        int getgicode(string GlGroup_code);
        Task<IEnumerable<Report>> getAllAccount();
    }
}
