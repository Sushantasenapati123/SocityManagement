using Bank.Domain.AccountType;
using Bank.Irepository.AccountType;
using Dapper;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using static Bank.Domain.Customer.CustmerEntity;

namespace Bank.Repository.AccountYpe
{
    public class AccountTypeRepository : RepositoryBase, IAccountTypeRepository
    {
        public AccountTypeRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public int accountAdd(AccountTypeModel at)
        {
            try
            {

                var query = "sp_accounttype_op";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@action", "I");
                    dypara.Add("@GlGroup_code", at.GlGroup_code);
                    dypara.Add("@gl_code", at.gl_code);
                    dypara.Add("@gl_nature", at.gl_nature);
                    dypara.Add("@GL_NAME", at.GL_NAME);
                    var res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public int Deleteaccount(int id)
        {
            try
            {
                var query = "sp_accounttype_op";
                

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "D");
                    dypara.Add("@AccountType_id", id);
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<AccountTypeModel>> getaccount()
        {
            List<AccountTypeModel> res = new List<AccountTypeModel>();
            try
            {
                var query = "sp_accounttype_op";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "A");

                    var result = await Connection.QueryAsync<AccountTypeModel>(query, dypara, commandType: CommandType.StoredProcedure);
                    return result;
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<AccountTypeModel> Getaccount(int id)
        {

            try
            {
                var query = "sp_accounttype_op";
                

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "S");
                    dypara.Add("@AccountType_id", id);
                    var res = await Connection.QueryFirstOrDefaultAsync<AccountTypeModel>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public int Updateaccount(AccountTypeModel at)
        {
            try
            {
                var query = "sp_accounttype_op";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@action", "U");
                    dypara.Add("@AccountType_id", at.AccountType_id);
                    dypara.Add("@GlGroup_code", at.GlGroup_code);
                    dypara.Add("@gl_code", at.gl_code);
                    dypara.Add("@gl_nature", at.gl_nature);
                    dypara.Add("@GL_NAME", at.GL_NAME);
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<IEnumerable<AccountTypeModel>> GetGIGroupCode()
        {
            try
            {
                AccountTypeModel at = new AccountTypeModel();
                var query = "sp_accounttype_op";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@action", "M");

                    var result = await Connection.QueryAsync<AccountTypeModel>(query, dypara, commandType: CommandType.StoredProcedure);
                    return result;
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int getgicode(string GlGroup_code)
        {
            var query = "sp_accounttype_op";
           
                var dypara = new DynamicParameters();
                dypara.Add("@GlGroup_code", GlGroup_code);
                dypara.Add("@action", "P");
                dypara.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                int result = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                var cc = Convert.ToInt32(dypara.Get<String>("PMSGOUT"));
                return cc;

            
            
        }
        public async Task<IEnumerable<Report>> getAllAccount()
        {
            try
            {
                AccountTypeModel at = new AccountTypeModel();
                var query = "usp_account";

                var dypara = new DynamicParameters();
                dypara.Add("@action", "SA");

                var result = await Connection.QueryAsync<Report>(query, dypara, commandType: CommandType.StoredProcedure);
                return result;

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
