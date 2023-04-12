using Bank.Domain.Login;
using Bank.Irepository.Login;
using Dapper;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.Login
{
    public class loginRepository : RepositoryBase, IloginRepository
    {

        public loginRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<LoginEntity> GetAccount(string id, string psw)
        {
            try
            {
                //var query = "usp_accoUsp_userloginunt";

                var dypara = new DynamicParameters();
                dypara.Add("@Action", "LOGIN");
                dypara.Add("@USER_ID", id);
                dypara.Add("@USER_PASSWORD", psw);
                //var res = con.Query<LoginEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return (await Connection.QueryAsync<LoginEntity>("usp_accoUsp_userloginunt", dypara, commandType: CommandType.StoredProcedure)).AsList()[0];

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public List<LoginEntity> GetDetails(LoginEntity lobj)
        {

            var param = new DynamicParameters();

            param.Add("@USER_ID", lobj.USER_ID);
            param.Add("@USER_PASSWORD", lobj.USER_PASSWORD);
            param.Add("@ACTION", "LOGIN");
            param.Add("PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
            var exR = Connection.Query<LoginEntity>("Usp_Masterlogin", param, commandType: CommandType.StoredProcedure);

            return exR.AsList();



        }

    }
}