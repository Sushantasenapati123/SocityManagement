using Bank.Domain.AccountOpening;
using Bank.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Bank.Domain.Customer.CustmerEntity;

namespace Bank.Irepository.Customer
{
    public interface ICustmerRepository
    {
      
        Task<IEnumerable<Report>> getAccountType();
        Task<IEnumerable<CustmerEntity>> listcustmer(CustmerEntity cu);
        Task<IEnumerable<Report>> listOfReport(Report cu);
        Task<IEnumerable<Report>> listOfTranscationReportByAccountNum(Report cu);
        Task<IEnumerable<CustmerEntity>> listcustmerBranchWise(CustmerEntity cu);
        public int ApprovedCustomer(int id, string manager,int status);//approve customer profile//
        public int ChangeBranchByAdmin(int id, string manager);
        public int UpdateServerDate(string date, string BranchName);//approve customer profile

        Task<IEnumerable<CustmerEntity>> viewApprovedCustomerBefore(CustmerEntity cu);// approved customer
        Task<IEnumerable<CustmerEntity>> viewPendingDepositeamount(CustmerEntity cu);
        Task<IEnumerable<CustmerEntity>> viewPendingWithdrowamount(CustmerEntity cu);
        Task<IEnumerable<CustmerEntity>> BindVoucher(string branch);
        Task<IEnumerable<CustmerEntity>> viewPendingCustomerBefore(CustmerEntity cu);// pending customer


        Task<IEnumerable<AccountopeningEntity>> listPendingcustmer(AccountopeningEntity cu);//pending account
        Task<IEnumerable<AccountopeningEntity>> listApprovedcustmer(AccountopeningEntity cu);//// approved account
        int insertcustmer(CustmerEntity rl);
        int insertsavingAmount(CustmerEntity rl);
        int WithdrowAmount(CustmerEntity rl);
        int updatecustmer(CustmerEntity rl);
        int deletecustmer(int id); 
              int Appprove_Deposite(int id);
        int Appprove_WithdrowAmount(int id);
        public CustmerEntity custmerselect(int id,string Branch);

        public CustmerEntity GetAccountDetailByAccountNo(Int64 id);
        public CustmerEntity custmerbind(int id);
        Task<IEnumerable<CustmerEntity>> Viewpendinglistcustmer(CustmerEntity cu);
    }
}
