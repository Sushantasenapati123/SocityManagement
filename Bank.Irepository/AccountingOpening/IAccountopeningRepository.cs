using Bank.Domain.AccountOpening;
using Bank.Domain.AccountType;
using Bank.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Irepository.AccountingOpening
{
    public interface IAccountopeningRepository
    {
        public  Task<IEnumerable<AccountopeningEntity>> Viewallaccountballance(int id);
        public Task<AccountTypeModel> GetGLcodeByGLName(string glName);
        public int AddAccount(AccountopeningEntity acc);
        public Task<List<AccountTypeModel>> AutoCompleteBankName();

        public int ApprovedCustomer(int acc,int staus,string manager, DateTime Trans_Date, string Particular, string Voucher_Type,string s,string Scroll_Terminal_Code,string Headofaccount,int amountFromBank, string bankcode);//approve customer account
        public Task<AccountopeningEntity> getdetails(string id);  // Used for Edit button ApprovedCustomer
        public Task<IEnumerable<AccountopeningEntity>> ViewAccountOpendedCustomer(AccountopeningEntity id);
        public CustmerEntity GetRateOfIntrest(string accountype);
        public int deletecustmer(int id);
        public AccountopeningEntity custmerselect(int id);

        public Task<AccountopeningEntity> ViewAccountDetailsById(int id);//

        public Task<AccountopeningEntity> get_last_tblvoucherrecord();
        public Task<AccountopeningEntity> BindShearDetails(int id,string s);

        public Task<IEnumerable<fillddl>> BindDdlForaccount(int id,string branchname);
        public Task<IEnumerable<fillddl>> BindDdlForPendingaccount(int id);

    }
}
