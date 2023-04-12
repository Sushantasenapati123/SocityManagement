using Bank.Domain.Customer;
using Dapper;
using System.Linq;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Bank.Irepository.Customer;
using Bank.Domain.AccountOpening;
using static Bank.Domain.Customer.CustmerEntity;

namespace Bank.Repository.Customer
{
    public class CustomerRepository : RepositoryBase, ICustmerRepository
    {
        public CustomerRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public int ApprovedCustomer(int acc,string manager,int status)
        {
            try
            {
                // var query = "USP_depomast";
                var query = "[USP_customer]";

                var dypara = new DynamicParameters();

                dypara.Add("@CUSTOMER_id", acc);//@Approved_By
                dypara.Add("@ApprovedBy", manager);
                if(status==1)
                dypara.Add("@ACTION", "ApproveCustomerProfile");
                else
                dypara.Add("@ACTION", "RejectCustomerProfile");

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
        public int ChangeBranchByAdmin(int branchid, string Userid)//
        {
            try
            {
                // var query = "USP_depomast";
                var query = "[USP_customer]";

                var dypara = new DynamicParameters();

                dypara.Add("@branch_idd", branchid);
                dypara.Add("@userid", Userid);
                dypara.Add("@ACTION", "UpdateAdminBranch");
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
        public int UpdateServerDate(string date, string BranchNAme)
        {
            try
            {
                // var query = "USP_depomast";
                var query = "[USP_customer]";

                var dypara = new DynamicParameters();

                dypara.Add("@Branch_Name", BranchNAme);//@Approved_By
                dypara.Add("@ServarDate", date);
               
                dypara.Add("@ACTION", "UpdateServerDate");

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
        public int insertcustmer(CustmerEntity cust)
        {
            try
            {
                var query = "USP_customer";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "I");
                    dypara.Add("@BranchName", cust.Branch_Name);
                    dypara.Add("@CUSTOMER_id", cust.CUSTOMER_id);
                    dypara.Add("@Photo", cust.Photo);
                    dypara.Add("@Email", cust.Email);
                    dypara.Add("@Customer_Code", cust.Customer_Code);
                    dypara.Add("@NAME_INITIALS", cust.NAME_INITIALS);
                    dypara.Add("@CUSTOMER_NAME", cust.CUSTOMER_NAME);
                    dypara.Add("@aadharno", cust.aadharno);
                    dypara.Add("@addressproof", cust.addressproof);
                    dypara.Add("@AGE", cust.AGE);
                    dypara.Add("@ANNUAL_INCOME_1", cust.ANNUAL_INCOME_1);
                    dypara.Add("@ANNUAL_INCOME_2", cust.ANNUAL_INCOME_2);
                    dypara.Add("@B_REL_1", cust.B_REL_1);
                    dypara.Add("@B_REL_2", cust.B_REL_2);
                    dypara.Add("@CASTE", cust.CASTE);
                    dypara.Add("@CREATED_BY", cust.CREATED_BY);
                    dypara.Add("@CUR_ADDRESS_1", cust.CUR_ADDRESS_1);
                    dypara.Add("@CUR_ADDRESS_2", cust.CUR_ADDRESS_2);
                    dypara.Add("@CUR_ADDRESS_3", cust.CUR_ADDRESS_3);
                    // dypara.Add("@CUSTOMER_id", cust.CUSTOMER_id);
                    dypara.Add("@DATE_ENROLLED", cust.DATE_ENROLLED);
                    dypara.Add("@DATE_OF_INCORPORATION", cust.DATE_OF_INCORPORATION);
                    dypara.Add("@DOB", cust.DOB);
                    dypara.Add("@Introducer", cust.Introducer);
                    dypara.Add("@DOM", cust.DOM);

                    dypara.Add("@CurrentPIN", cust.CurrentPIN);
                    dypara.Add("@CurPHONE_NO_1", cust.CurPHONE_NO_1);
                    dypara.Add("@CurPHONE_NO_2", cust.CurPHONE_NO_2);

                     dypara.Add("@FATHER_HUSBAND", cust.FATHER_HUSBAND);
                    dypara.Add("@INTRODUCER_CUSTOMER_id", cust.INTRODUCER_CUSTOMER_id);
                    dypara.Add("@IS_MINOR", cust.IS_MINOR);
                    dypara.Add("@IS_STAFF", cust.IS_STAFF);
                    dypara.Add("@LEGAL_HAIR_NAME", cust.LEGAL_HAIR_NAME);
                    dypara.Add("@MOTHER_WIFE", cust.MOTHER_WIFE);
                    //dypara.Add("@NAME_INITIALS", cust.NAME_INITIALS);
                    dypara.Add("@NATURE_OF_BUS", cust.NATURE_OF_BUS);
                    dypara.Add("@OCCUPATION", cust.OCCUPATION);
                    dypara.Add("@OCCUPATION_OTHER", cust.OCCUPATION_OTHER);
                    dypara.Add("@OTHER_NATURE_NAME", cust.OTHER_NATURE_NAME);
                    dypara.Add("@OTHER_SOURCE", cust.OTHER_SOURCE);
                    dypara.Add("@PAN_NO", cust.PAN_NO);
                    dypara.Add("@PASSED_BY", cust.PASSED_BY);
                    dypara.Add("@PER_ADDRESS_1", cust.PER_ADDRESS_1);
                    dypara.Add("@PER_ADDRESS_2", cust.PER_ADDRESS_2);
                    dypara.Add("@PER_ADDRESS_3", cust.PER_ADDRESS_3);
                    dypara.Add("@PER_PHN_1", cust.PER_PHN_1);
                    dypara.Add("@PER_PHN_2", cust.PER_PHN_2);
                    dypara.Add("@PER_PIN", cust.PER_PIN);
                    dypara.Add("@PHONE_NO_1", cust.PHONE_NO_1);
                    dypara.Add("@PHONE_NO_2", cust.PHONE_NO_2);
                    dypara.Add("@PHOTOSIGNATURE", cust.PHOTOSIGNATURE);
                    dypara.Add("@PIN", cust.PIN);
                    dypara.Add("@QUALIFICATION", cust.QUALIFICATION);
                    dypara.Add("@RESIDENCE_TYPE", cust.RESIDENCE_TYPE);
                    dypara.Add("@SALARIED_WITH", cust.SALARIED_WITH);
                    dypara.Add("@SALARIED_WITH_OTHER", cust.SALARIED_WITH_OTHER);
                    dypara.Add("@SELF_EMP_PROFESSIONAL", cust.SELF_EMP_PROFESSIONAL);
                    dypara.Add("@SELF_EMP_PROFESSIONAL_OTHER", cust.SELF_EMP_PROFESSIONAL_OTHER);
                    dypara.Add("@SENIOR_CITIZEN", cust.SENIOR_CITIZEN);
                    dypara.Add("@SEX", cust.SEX);
                    dypara.Add("@SOURCE_OF_FUNDS", cust.SOURCE_OF_FUNDS);
                    dypara.Add("@TYPE_OF_COMP", cust.TYPE_OF_COMP);
                    dypara.Add("@IdentificationNo", cust.IdentificationNo);
                    dypara.Add("@TYPE_OF_COMP_OTHER", cust.TYPE_OF_COMP_OTHER);
                    dypara.Add("@AddreeProofType", cust.AddreeProofType);
                    dypara.Add("@AddreeProofCopy", cust.AddreeProofCopy);

                dypara.Add("@EnteredByy", cust.EnteredByy);
                dypara.Add("@ApprovedBy", null);

                dypara.Add("PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                    int Result = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);

                    var cc = Convert.ToInt32(dypara.Get<String>("PMSGOUT"));
                    return cc;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int insertsavingAmount(CustmerEntity cust)
        {
            try
            {
                var query = "USP_customer";

                var dypara = new DynamicParameters();
                dypara.Add("@Action", "Temp_savingAmount");
                dypara.Add("@NewAccountNo", cust.NewAccountNo);
                dypara.Add("@Account_Typee", cust.Account_Type);
                dypara.Add("@Name", cust.customername);
                dypara.Add("@Amount", cust.Amount); 
                     dypara.Add("@Branch", cust.BranchName);



                dypara.Add("PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                int Result = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);

                var cc = Convert.ToInt32(dypara.Get<String>("PMSGOUT"));
                return cc;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public CustmerEntity custmerbind(int id)
        {
            throw new NotImplementedException();
        }

        public CustmerEntity custmerselect(int id,string branch)
        {
            try
            {
                var query = "USP_customer";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "S");
                    dypara.Add("@Branch_Name", branch);
                    dypara.Add("@Customer_Code", id);
                    var res = Connection.Query<CustmerEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res.FirstOrDefault();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
         public CustmerEntity GetAccountDetailByAccountNo(Int64 num)
        {
            try
            {
                var query = "USP_customer";

                var dypara = new DynamicParameters();
                dypara.Add("@Action", "GetAccountDetailByAccountNo");
                dypara.Add("@Account_Numberr", num);
                var res = Connection.Query<CustmerEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deletecustmer(int id)
        {
            try
            {
                var query = "USP_customer";


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

        public int Appprove_Deposite(int id)
        {
            try
            {
                var query = "USP_customer";


                var dypara = new DynamicParameters();
                dypara.Add("@Action", "Appprove_Deposite");
                dypara.Add("@trans_id", id);
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


        public async Task<IEnumerable<CustmerEntity>> listcustmer(CustmerEntity cu)
        {
            try
            { 
                var query = "USP_customer";
                if (cu.CUSTOMER_NAME == null)
                    cu.CUSTOMER_NAME = "";
                var dypara = new DynamicParameters();
                dypara.Add("@pname",cu.CUSTOMER_NAME);
                dypara.Add("@Branch_Name", cu.Branch_Name);

                dypara.Add("@Action", "z");

                var res = Connection.Query<CustmerEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<Report>> getAccountType()
        {
            try
            {
                var query = "Usp_Branch_Details";


                var dypara = new DynamicParameters();
                dypara.Add("@Action", "z");
                var res = await Connection.QueryAsync<Report>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<Report>> listOfReport(Report cu)
        {
            try
            {
                var query = "USP_customer";
                //if (cu.CUSTOMER_NAME == null)
                //    cu.CUSTOMER_NAME = "";
                var dypara = new DynamicParameters();
                dypara.Add("@branch_id4", cu.branch_id);
                dypara.Add("@From_Date", cu.From_Date);
                dypara.Add("@To_Date", cu.To_Date);
                dypara.Add("@AccountType_id", cu.AccountType_id);

                dypara.Add("@Action", "BindReport");

                var res = Connection.Query<Report>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<CustmerEntity>> Viewpendinglistcustmer(CustmerEntity cu)
        {
            try
            {
                var query = "USP_customer";
                if (cu.CUSTOMER_NAME == null)
                    cu.CUSTOMER_NAME = "";
                var dypara = new DynamicParameters();
                dypara.Add("@pname", cu.CUSTOMER_NAME);
                dypara.Add("@Branch_Name", cu.Branch_Name);

                dypara.Add("@Action", "CustPending");

                var res = Connection.Query<CustmerEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<AccountopeningEntity>> listPendingcustmer(AccountopeningEntity cu)
        {
            try
            {
                
                var query = "USP_customer";
                var dypara = new DynamicParameters();
                dypara.Add("@Branch_Name", cu.Branch_Name);
                dypara.Add("@Action", "ViewPendingAccount");
               

                var res = Connection.Query<AccountopeningEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<AccountopeningEntity>> listApprovedcustmer(AccountopeningEntity cu)
        {
            try
            {

                var query = "USP_customer";
                var dypara = new DynamicParameters();
                dypara.Add("@Branch_Name", cu.Branch_Name);
                dypara.Add("@Action", "ViewActiveAccount");


                var res = Connection.Query<AccountopeningEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<IEnumerable<CustmerEntity>> viewApprovedCustomerBefore(CustmerEntity cu)//approve customer
        {
            try
            {

                var query = "USP_customer";
                var dypara = new DynamicParameters();
                dypara.Add("@Branch_Name", cu.Branch_Name);
                dypara.Add("@Action", "ViewActiveCustomer");


                var res = Connection.Query<CustmerEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<CustmerEntity>> viewPendingDepositeamount(CustmerEntity cu)//approve customer
        {
            try
            {

                var query = "USP_customer";
                var dypara = new DynamicParameters();
              
                dypara.Add("@Action", "getall_savingTranAmount");


                var res = Connection.Query<CustmerEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<CustmerEntity>> BindVoucher(string branch)//approve customer
        {
            try
            {

                var query = "USP_customer";
                var dypara = new DynamicParameters();
                dypara.Add("@Action", "BindVaucher");
                dypara.Add("@Branch_Name", branch);

                var res = Connection.Query<CustmerEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<CustmerEntity>> viewPendingCustomerBefore(CustmerEntity cu)////pending customer
        {
            try
            {

                var query = "USP_customer";
                var dypara = new DynamicParameters();
                dypara.Add("@Branch_Name", cu.Branch_Name);
                dypara.Add("@Action", "ViewPendingCustomer");


                var res = Connection.Query<CustmerEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<CustmerEntity>> listcustmerBranchWise(CustmerEntity cu)
        {
            try
            {

                var query = "USP_customer";
                var dypara = new DynamicParameters();
                dypara.Add("@Branchid", cu.branch_id);
                dypara.Add("@Action", "A");


                var res = Connection.Query<CustmerEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int updatecustmer(CustmerEntity cust)
        {
            try
            {
                var query = "USP_customer";
              
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "U");
                    dypara.Add("@CUSTOMER_id", cust.CUSTOMER_id);
                    dypara.Add("@NAME_INITIALS", cust.NAME_INITIALS);
                    dypara.Add("@CUSTOMER_NAME", cust.CUSTOMER_NAME);
                    dypara.Add("@aadharno", cust.aadharno);
                    dypara.Add("@addressproof", cust.addressproof);
                    dypara.Add("@AGE", cust.AGE);
                    dypara.Add("@ANNUAL_INCOME_1", cust.ANNUAL_INCOME_1);
                    dypara.Add("@ANNUAL_INCOME_2", cust.ANNUAL_INCOME_2);
                    dypara.Add("@B_REL_1", cust.B_REL_1);
                    dypara.Add("@B_REL_2", cust.B_REL_2);
                    dypara.Add("@CASTE", cust.CASTE);
                    dypara.Add("@CREATED_BY", cust.CREATED_BY);
                    dypara.Add("@CUR_ADDRESS_1", cust.CUR_ADDRESS_1);
                    dypara.Add("@CUR_ADDRESS_2", cust.CUR_ADDRESS_2);
                    dypara.Add("@CUR_ADDRESS_3", cust.CUR_ADDRESS_3);
                    // dypara.Add("@CUSTOMER_id", cust.CUSTOMER_id);
                    dypara.Add("@DATE_ENROLLED", cust.DATE_ENROLLED);
                    dypara.Add("@DATE_OF_INCORPORATION", cust.DATE_OF_INCORPORATION);
                    dypara.Add("@DOB", cust.DOB);
                    dypara.Add("@DOM", cust.DOM);
                    dypara.Add("@FATHER_HUSBAND", cust.FATHER_HUSBAND);
                    dypara.Add("@INTRODUCER_CUSTOMER_id", cust.INTRODUCER_CUSTOMER_id);
                    dypara.Add("@IS_MINOR", cust.IS_MINOR);
                    dypara.Add("@IS_STAFF", cust.IS_STAFF);
                    dypara.Add("@LEGAL_HAIR_NAME", cust.LEGAL_HAIR_NAME);
                    dypara.Add("@MOTHER_WIFE", cust.MOTHER_WIFE);
                    dypara.Add("@NAME_INITIALS", cust.NAME_INITIALS);
                    dypara.Add("@NATURE_OF_BUS", cust.NATURE_OF_BUS);
                    dypara.Add("@OCCUPATION", cust.OCCUPATION);
                    dypara.Add("@OCCUPATION_OTHER", cust.OCCUPATION_OTHER);
                    dypara.Add("@OTHER_NATURE_NAME", cust.OTHER_NATURE_NAME);
                    dypara.Add("@OTHER_SOURCE", cust.OTHER_SOURCE);
                    dypara.Add("@PAN_NO", cust.PAN_NO);
                    dypara.Add("@PASSED_BY", cust.PASSED_BY);
                    dypara.Add("@PER_ADDRESS_1", cust.PER_ADDRESS_1);
                    dypara.Add("@PER_ADDRESS_2", cust.PER_ADDRESS_2);
                    dypara.Add("@PER_ADDRESS_3", cust.PER_ADDRESS_3);
                    dypara.Add("@PER_PHN_1", cust.PER_PHN_1);
                    dypara.Add("@PER_PHN_2", cust.PER_PHN_2);
                    dypara.Add("@PER_PIN", cust.PER_PIN);
                    dypara.Add("@PHONE_NO_1", cust.PHONE_NO_1);
                    dypara.Add("@PHONE_NO_2", cust.PHONE_NO_2);
                    dypara.Add("@PHOTOSIGNATURE", cust.PHOTOSIGNATURE);
                    dypara.Add("@PIN", cust.PIN);
                    dypara.Add("@QUALIFICATION", cust.QUALIFICATION);
                    dypara.Add("@RESIDENCE_TYPE", cust.RESIDENCE_TYPE);
                    dypara.Add("@SALARIED_WITH", cust.SALARIED_WITH);
                    dypara.Add("@SALARIED_WITH_OTHER", cust.SALARIED_WITH_OTHER);
                    dypara.Add("@SELF_EMP_PROFESSIONAL", cust.SELF_EMP_PROFESSIONAL);
                    dypara.Add("@SELF_EMP_PROFESSIONAL_OTHER", cust.SELF_EMP_PROFESSIONAL_OTHER);
                    dypara.Add("@SENIOR_CITIZEN", cust.SENIOR_CITIZEN);
                    dypara.Add("@SEX", cust.SEX);
                    dypara.Add("@SOURCE_OF_FUNDS", cust.SOURCE_OF_FUNDS);
                    dypara.Add("@TYPE_OF_COMP", cust.TYPE_OF_COMP);
                    dypara.Add("@TYPE_OF_COMP_OTHER", cust.TYPE_OF_COMP_OTHER);
                    dypara.Add("PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                    int Result = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);

                    var cc = Convert.ToInt32(dypara.Get<String>("PMSGOUT"));
                    return cc;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

       


        //paging//

    }
}
