﻿using Bank.Domain.AccountOpening;
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
        public int InsertingDailyDepositeListIntoTempTable(CustmerEntity ce);
        Task<IEnumerable<Report>> getAccountType();
        Task<IEnumerable<CustmerEntity>> listcustmer(CustmerEntity cu); 
               Task<IEnumerable<CustmerEntity>> ViewSummaryOfDatFile(CustmerEntity cu);
        Task<IEnumerable<CustmerEntity>> ViewUploadDatfileRecord(CustmerEntity cu);
        Task<IEnumerable<CustmerEntity>> listcustmerAgent(CustmerEntity cu);
        Task<IEnumerable<Report>> listOfReport(Report cu);
        Task<IEnumerable<CustmerEntity>> Agentwise_ViewDailyDepositeReport(CustmerEntity cu);
        Task<IEnumerable<Report>> listOfTranscationReportByAccountNum(Report cu);
        Task<IEnumerable<CustmerEntity>> listcustmerBranchWise(CustmerEntity cu);
        public int ApprovedCustomer(int id, string manager,int status);//approve customer profile//
        public int ChangeBranchByAdmin(int id, string manager);
        public int UpdateServerDate(string date, string BranchName);//approve customer profile

        Task<IEnumerable<CustmerEntity>> viewApprovedCustomerBefore(CustmerEntity cu);// approved customer
        Task<IEnumerable<CustmerEntity>> viewPendingDepositeamount(CustmerEntity cu);//
        Task<IEnumerable<CustmerEntity>> viewPendingDailyDepositeamount(CustmerEntity cu);
        Task<IEnumerable<CustmerEntity>> viewAllDailyDepositeApproveAccount(CustmerEntity cu);
        Task<IEnumerable<CustmerEntity>> viewPendingWithdrowamount(CustmerEntity cu);
        Task<IEnumerable<CustmerEntity>> BindVoucher(string branch);
        Task<IEnumerable<CustmerEntity>> viewPendingCustomerBefore(CustmerEntity cu);// pending customer

             Task<IEnumerable<CustmerEntity>> viewRejectCustomer(CustmerEntity cu);
        Task<IEnumerable<AccountopeningEntity>> listPendingcustmer(AccountopeningEntity cu);//pending account
        Task<IEnumerable<AccountopeningEntity>> listApprovedcustmer(AccountopeningEntity cu);//// approved account
        int insertcustmer(CustmerEntity rl);
        int insertsavingAmount(CustmerEntity rl);//
        int AddAgent(CustmerEntity rl);
        int WithdrowAmount(CustmerEntity rl);
        int updatecustmer(CustmerEntity rl);
        int deletecustmer(int id);
        Task<IEnumerable<Report>> ListOfTransactionbyBank(string cu);
        int Appprove_Deposite(int id);
        int Appprove_DailyDepositeTextfile(CustmerEntity ce);
        int Appprove_DailyDepositeTextfileXML(CustmerEntity ce);
        int Appprove_DepositeByAgent(DateTime Date,int id,string agentID, string branch, int Amount,int transid);
        int Appprove_WithdrowAmount(int id);
        public CustmerEntity custmerselect(int id,string Branch, string accountype);
        public CustmerEntity BindServerdate(string BranchNAme);
        Task<List<CustmerEntity>> BindcustomerNameCodeBind();

        Task<List<CustmerEntity>> BindAgentCode();

        public CustmerEntity GetAccountDetailByAccountNo(Int64 id);
        public CustmerEntity GetCustomerDetailByCustomerCode(Int64 id,string branchname);
        public CustmerEntity custmerbind(int id);
        Task<IEnumerable<CustmerEntity>> Viewpendinglistcustmer(CustmerEntity cu);
    }
}
