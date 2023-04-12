using Bank.Domain.Account;
using Bank.Irepository.Account;
using Dapper;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.Account
{
    public class AccountRepository : RepositoryBase, IAccountRepository
    {
        public AccountRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public int AddAccount(AccountEntity acc)
        {
            try
            {
                var query = "usp_account";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "I");
                    dypara.Add("@branch_id", acc.branch_id);
                    dypara.Add("@accounttype_id", acc.accounttype_id);
                    dypara.Add("@GlOb_Type", acc.GlOb_Type);
                    dypara.Add("@GlOb_date", acc.GlOb_date);
                    dypara.Add("@GlOb_Amount", acc.GlOb_Amount);
                    dypara.Add("@Gl_Status", acc.Gl_Status);
                    dypara.Add("@Lad_Percentage", acc.Lad_Percentage);
                    dypara.Add("@Penal_Rate", acc.Penal_Rate);
                    dypara.Add("PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    var cc = Convert.ToInt32(dypara.Get<String>("PMSGOUT"));
                    return cc;
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteAccount(int id)
        {
            try
            {
                var query = "usp_account";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "D");
                    dypara.Add("@Account_id", id);
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<AccountEntity> GetAccount(int id)
        {
            try
            {
                var query = "usp_account";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "S0");
                    dypara.Add("@Account_id", id);
                    var res = await Connection.QueryFirstOrDefaultAsync<AccountEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<AccountEntity>> GetAccounts()
        {
            try
            {
                var query = "usp_account";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "S");
                    var res = await Connection.QueryAsync<AccountEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateAccount(AccountEntity acc)
        {
            try
            {
                var query = "usp_account";
              

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "U");
                    dypara.Add("@Account_id", acc.Account_id);
                    dypara.Add("@branch_id", acc.branch_id);
                    dypara.Add("@accounttype_id", acc.accounttype_id);
                    dypara.Add("@GlOb_Type", acc.GlOb_Type);
                    dypara.Add("@GlOb_date", acc.GlOb_date);
                    dypara.Add("@GlOb_Amount", acc.GlOb_Amount);
                    dypara.Add("@Gl_Status", acc.Gl_Status);
                    dypara.Add("@Lad_Percentage", acc.Lad_Percentage);
                    dypara.Add("@Penal_Rate", acc.Penal_Rate);
                    dypara.Add("PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    var cc = Convert.ToInt32(dypara.Get<String>("PMSGOUT"));
                    return cc;
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<IEnumerable<AccountEntity>> GetAccTypes()
        {
            try
            {
                var query = "usp_account";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "SA");
                    var res = await Connection.QueryAsync<AccountEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<AccountEntity>> GetBranches()
        {
            try
            {
                var query = "usp_account";
              
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "SB");
                    var res = await Connection.QueryAsync<AccountEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
