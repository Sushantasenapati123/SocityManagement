using Bank.Domain.AccountOpening;
using Bank.Irepository.AccountingOpening;
using Dapper;
using System.Linq;

using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Bank.Domain.AccountType;

namespace Bank.Repository.AccountOpening
{
    public class AccountopeningRepositor : RepositoryBase, IAccountopeningRepository
    {
        public AccountopeningRepositor(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public int AddAccount(AccountopeningEntity acc)
        {
            try
            {
                // var query = "USP_depomast";
                var query = "UPS_OpeningdetailsUpdate";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@ACTION", "I");
                    dypara.Add("@Openingdetails_id", acc.Openingdetails_id);
                    dypara.Add("@HeadOfAccount", acc.HeadOfAccount);
                    dypara.Add("@BranchCode", acc.BranchCode);
                    dypara.Add("@Customer_Code", acc.Customer_Code);
                    dypara.Add("@Currentbal", acc.Currentbal);
                    dypara.Add("@Seniorcitizen", acc.Seniorcitizen);
                    dypara.Add("@customername", acc.customername);
                    dypara.Add("@Certificateno", acc.Certificateno);
                    dypara.Add("@staff", acc.staff);
                    dypara.Add("@Accountno", acc.Accountno);
                     dypara.Add("@Sex", acc.Sex);
                    dypara.Add("@Caste", acc.Caste);
                    dypara.Add("@Presentaddress", acc.Presentaddress);
                    dypara.Add("@Permanentaddress", acc.Permanentaddress);
                    dypara.Add("@Modeofoperation", acc.Modeofoperation);

                    dypara.Add("@OpeningDATE", acc.OpeningDATE);

                    dypara.Add("@Facevalue", acc.Facevalue);
                    dypara.Add("@NoUnint", acc.NoUnint);
                    dypara.Add("@Enterancefee", acc.Enterancefee);
                    dypara.Add("@IntroducerPresentaddress", acc.IntroducerPresentaddress);
                    dypara.Add("@Minimum_Balance", acc.Minimum_Balance);
                    dypara.Add("@Opening_Balance", acc.Opening_Balance);
                    dypara.Add("@Nomineename1", acc.Nomineename1);
                    dypara.Add("@Nomineerelation1", acc.Nomineerelation1);
                    dypara.Add("@Nomineeaddress1st1", acc.Nomineeaddress1st1);
                    dypara.Add("@Nomineeaddress2nd1", acc.Nomineeaddress2nd1);
                    dypara.Add("@Nomineeaddress3rd1", acc.Nomineeaddress3rd1);
                    dypara.Add("@pincode1", acc.pincode1);
                    dypara.Add("@phone1", acc.phone1);
                    dypara.Add("@Altphone1", acc.Altphone1);
                    dypara.Add("@Minimumbal1", acc.Minimumbal1);
                    dypara.Add("@Status1", acc.Status1);

                    dypara.Add("@Nomineename2", acc.Nomineename2);
                    dypara.Add("@Nomineerelation2", acc.Nomineerelation2);
                    dypara.Add("@Nomineeaddress1st2", acc.Nomineeaddress1st2);
                    dypara.Add("@Nomineeaddress2nd2", acc.Nomineeaddress2nd2);
                    dypara.Add("@Nomineeaddress3rd2", acc.Nomineeaddress3rd2);
                    dypara.Add("@pincode2", acc.pincode2);
                    dypara.Add("@phone2", acc.phone2);
                    dypara.Add("@Altphone2", acc.Altphone2);
                    dypara.Add("@Minimumbal2", acc.Minimumbal2);
                    dypara.Add("@Status2", acc.Status2);
                    dypara.Add("@Nomineename3", acc.Nomineename3);
                    dypara.Add("@Nomineerelation3", acc.Nomineerelation3);
                    dypara.Add("@Nomineeaddress1st3", acc.Nomineeaddress1st3);
                    dypara.Add("@Nomineeaddress2nd3", acc.Nomineeaddress2nd3);
                    dypara.Add("@Nomineeaddress3rd3", acc.Nomineeaddress3rd3);
                    dypara.Add("@pincode3", acc.pincode3);
                    dypara.Add("@phone3", acc.phone3);
                    dypara.Add("@Altphone3", acc.Altphone3);
                    dypara.Add("@Minimumbal3", acc.Minimumbal3);
                    dypara.Add("@Status3", acc.Status3);
                    dypara.Add("@Userid", acc.Userid);
                    dypara.Add("PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    var cc = Convert.ToInt32(dypara.Get<String>("PMSGOUT"));
                    //return cc;
                    return cc;

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        ////approve customer account
        public int ApprovedCustomer(int acc,int status,string manager, DateTime Trans_Date, string Particular, string Voucher_Type,string time,string Scroll_Terminal_Code,string headofaccount,int AmountFromBank,string bankcode)
        {
            try
            {
               
                var query = "[USP_customer]";
                var dypara = new DynamicParameters();
                if(status==1)
                {
                    dypara.Add("@ACTION", "ApprovedCustomerAccount");
                }
               
                else
                dypara.Add("@ACTION", "RejectCustomer"); 

                 dypara.Add("@BranchName", bankcode);
                dypara.Add("@HeadOfAccount", headofaccount);
                dypara.Add("@AmountFromBank", AmountFromBank);
                dypara.Add("@Trans_Date", Trans_Date);
                if(headofaccount== "Fixed")
                    dypara.Add("@Trans_TimeOfEntry", DateTime.Now.ToString().Split(' ')[1]);
                else
                dypara.Add("@Trans_TimeOfEntry", time);
                dypara.Add("@Particular", Particular);
                dypara.Add("@Voucher_Type", Voucher_Type);
                dypara.Add("@Scroll_Terminal_Code", Scroll_Terminal_Code);
                dypara.Add("@Openingdetails_id", acc);
                dypara.Add("@Approved_By", manager);

                dypara.Add("PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                var cc = Convert.ToInt32(dypara.Get<String>("PMSGOUT"));
                return cc;
              


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public async Task<List<AccountTypeModel>> AutoCompleteBankName()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "AutoCompltBankName");
                var x = Connection.Query<AccountTypeModel>("USP_customer", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<AccountTypeModel> GetGLcodeByGLName(string glName)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "AutoFillGlCode");
                param.Add("@gl_nature", glName);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var doc = Connection.Query<AccountTypeModel>("USP_customer", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return doc;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<AccountopeningEntity> getdetails(string id)
        {
            try
            {

                var query = "Usp_userlogin";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@ACTION", "SA");
                    dypara.Add("@USER_ID", id);
                    var res = await Connection.QueryFirstOrDefaultAsync<AccountopeningEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
               

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public async Task<IEnumerable<AccountopeningEntity>> Viewallaccountballance(int Customer_Code)
        {
            try
            {

                var query = "UPS_OpeningdetailsUpdate";
                var dypara = new DynamicParameters();
                dypara.Add("@ACTION", "Viewallaccountballance");
                dypara.Add("@Customer_Code", Customer_Code);
                var res =Connection.Query<AccountopeningEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<IEnumerable<AccountopeningEntity>> ViewAccountOpendedCustomer(AccountopeningEntity id)
        {
            try
            {

                var query = "UPS_OpeningdetailsUpdate";

                var dypara = new DynamicParameters();
                dypara.Add("@ACTION", "A");
             
                dypara.Add("@customername", id.customername);
                dypara.Add("@HeadOfAccount", id.HeadOfAccount);
                var res = Connection.Query<AccountopeningEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public int deletecustmer(int id)
        {
            try
            {
                var query = "UPS_OpeningdetailsUpdate";


                var dypara = new DynamicParameters();
                dypara.Add("@Action", "D");
                dypara.Add("@Customer_Code", id);
                dypara.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                int res = Convert.ToInt32(dypara.Get<string>("@PMSGOUT"));
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AccountopeningEntity custmerselect(int id)
        {
            try
            {
                var query = "UPS_OpeningdetailsUpdate";

                var dypara = new DynamicParameters();
                dypara.Add("@Action", "S");
                dypara.Add("@Customer_Code", id);
                var res = Connection.Query<AccountopeningEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<fillddl>> BindDdlForaccount(int id,string BranchName)//BindDdlForPendingaccount
        {
            try
            {
                var query = "UPS_OpeningdetailsUpdate";

                var dypara = new DynamicParameters();
                dypara.Add("@Action", "BindAccount");
                dypara.Add("@BranchName", BranchName);
                dypara.Add("@Customer_Code", id);
                var res = Connection.Query<fillddl>(query, dypara, commandType: CommandType.StoredProcedure);
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<fillddl>> BindDdlForPendingaccount(int id)
        {
            try
            {
                var query = "UPS_OpeningdetailsUpdate";

                var dypara = new DynamicParameters();
                dypara.Add("@Action", "BindPendingAccount");
                dypara.Add("@Customer_Code", id);
                var res = Connection.Query<fillddl>(query, dypara, commandType: CommandType.StoredProcedure);
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async  Task<AccountopeningEntity> ViewAccountDetailsById(int id)
        {
            try
            {
                var query = "UPS_OpeningdetailsUpdate";

                var dypara = new DynamicParameters();
                dypara.Add("@Action", "ViewAccountDetails");
                dypara.Add("@Openingdetails_id", id);
                var res = Connection.Query<AccountopeningEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<AccountopeningEntity> get_last_tblvoucherrecord()
        {
            try
            {
                var query = "USP_customer";
                var dypara = new DynamicParameters();
                dypara.Add("@Action", "get_last_recod_tblVoucher");
                var res = Connection.Query<AccountopeningEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<AccountopeningEntity> BindShearDetails(int Customer_Code, string branchname)
        {
            try
            {
                var query = "UPS_OpeningdetailsUpdate";

                var dypara = new DynamicParameters();
                dypara.Add("@Action", "BindShearCapdetail");
                dypara.Add("@Customer_Code", Customer_Code);
                dypara.Add("@Branch_Name", branchname);
                var res = Connection.Query<AccountopeningEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

    }
}
