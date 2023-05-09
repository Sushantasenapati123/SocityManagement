using Bank.Domain.User;
using Bank.Irepository.User;
using Dapper;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.User
{
    public class UserRepository :RepositoryBase, IUserRepository
    {
        public UserRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public int AddUser(UserEntity usr)
        {
            try
            {
                var query = "usp_akb_USER_Operation";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "I");
                    dypara.Add("@USER_ID", usr.USER_ID);
                    dypara.Add("@USER_NAME", usr.USER_NAME);
                    dypara.Add("@USER_PASSWORD", usr.USER_PASSWORD);
                    dypara.Add("@FROM_DATE", usr.FROM_DATE);
                    dypara.Add("@TO_DATE", usr.TO_DATE);
                    dypara.Add("@USER_STATUS", usr.USER_STATUS);
                    dypara.Add("@ROLE_ID", usr.ROLE_ID);
                    dypara.Add("@USER_EMAIL", usr.USER_EMAIL);
                    dypara.Add("@USER_MOBILE", usr.USER_MOBILE);
                    dypara.Add("@BRANCH_id", usr.BRANCH_id);
                    dypara.Add("@Agent_Code", usr.Agent_Code);
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

        public int DeleteUser(int ID)
        {
            try
            {
                var query = "usp_akb_USER_Operation";
                

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "D");
                    dypara.Add("@ID", ID);
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<UserEntity>> getbranchids()
        {
            try
            {
                var query = "usp_akb_USER_Operation";
              

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "F");
                    var res = await Connection.QueryAsync<UserEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<UserEntity>> getrollids()
        {
            try
            {
                var query = "usp_akb_USER_Operation";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "A");
                    var res = await Connection.QueryAsync<UserEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<UserEntity> GetUser(int id)
        {
            try
            {
                var query = "usp_akb_USER_Operation";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "E");
                    dypara.Add("@ID", id);
                    var res = await Connection.QueryFirstOrDefaultAsync<UserEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<UserEntity>> getusers()
        {
            try
            {
                var query = "usp_akb_USER_Operation";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "S");
                    var res = await Connection.QueryAsync<UserEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                }

            
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateUser(UserEntity usr)
        {
            try
            {
                var query = "usp_akb_USER_Operation";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "U");
                    dypara.Add("@ID", usr.ID);
                    dypara.Add("@USER_ID", usr.USER_ID);
                    dypara.Add("@USER_NAME", usr.USER_NAME);
                    dypara.Add("@USER_PASSWORD", usr.USER_PASSWORD);
                    dypara.Add("@FROM_DATE", usr.FROM_DATE);
                    dypara.Add("@TO_DATE", usr.TO_DATE);
                    dypara.Add("@USER_STATUS", usr.USER_STATUS);
                    dypara.Add("@ROLE_ID", usr.ROLE_ID);
                    dypara.Add("@USER_EMAIL", usr.USER_EMAIL);
                    dypara.Add("@USER_MOBILE", usr.USER_MOBILE);
                    dypara.Add("@BRANCH_id", usr.BRANCH_id);

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
    }
}
