using Bank.Domain.Role;
using System.Linq;
using Bank.Irepository.ServerData;
using Dapper;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.Role
{
    public class RoleRepository : RepositoryBase, IRoleRegistation
    {
        public RoleRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }



        public int insertrole(RoleEntity rl)
        {

            try
            {
                var query = "Usp_UserRole";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "I");
                    dypara.Add("@ROLE_NAME", rl.ROLE_NAME);
                    dypara.Add("@ALLOW_GL", rl.ALLOW_GL);
                    dypara.Add("@ALLOW_CC", rl.ALLOW_CC);
                    dypara.Add("@ALLOW_EC", rl.ALLOW_EC);
                    dypara.Add("@ALLOW_AC", rl.ALLOW_AC);
                    dypara.Add("@ALLOW_SPCL", rl.ALLOW_SPCL);
                    dypara.Add("@ALLOW_NEW_DEPO", rl.ALLOW_NEW_DEPO);
                    dypara.Add("@ALLOW_NEW_LOAN", rl.ALLOW_NEW_LOAN);
                    dypara.Add("@ALLOW_INT_PARA", rl.ALLOW_INT_PARA);
                    dypara.Add("@ALLOW_VCH", rl.ALLOW_VCH);
                    dypara.Add("@ALLOW_DISBURSE", rl.ALLOW_DISBURSE);
                    dypara.Add("@ALLOW_LN_REPAY", rl.ALLOW_LN_REPAY);
                    dypara.Add("@ALLOW_VCH_AP", rl.ALLOW_VCH_AP);
                    dypara.Add("@ALLOW_DEPO_AP", rl.ALLOW_DEPO_AP);
                    dypara.Add("@ALLOW_LN_AP", rl.ALLOW_LN_AP);
                    dypara.Add("@ALLOW_CR_USR", rl.ALLOW_CR_USR);
                    dypara.Add("@ALLOW_BNK_INFO", rl.ALLOW_BNK_INFO);
                    dypara.Add("@ALLOW_RENEW_EXP", rl.ALLOW_RENEW_EXP);
                    dypara.Add("@ALLOW_VCH_EDIT", rl.ALLOW_VCH_EDIT);
                    dypara.Add("@ALLOW_VCH_EDIT", rl.ALLOW_VCH_EDIT);

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

        public async Task<IEnumerable<RoleEntity>> listrole()
        {

            try
            {
                var query = "Usp_UserRole";
              
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "A");

                    var result = await Connection.QueryAsync<RoleEntity>(query, dypara, commandType: CommandType.StoredProcedure);


                    return result;
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int updaterol(RoleEntity rl)
        {
            try
            {
                var query = "Usp_UserRole";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "U");
                    dypara.Add("@ROLE_ID", rl.ROLE_ID);
                    dypara.Add("@ROLE_NAME", rl.ROLE_NAME);
                    dypara.Add("@ALLOW_GL", rl.ALLOW_GL);
                    dypara.Add("@ALLOW_CC", rl.ALLOW_CC);
                    dypara.Add("@ALLOW_EC", rl.ALLOW_EC);
                    dypara.Add("@ALLOW_AC", rl.ALLOW_AC);
                    dypara.Add("@ALLOW_SPCL", rl.ALLOW_SPCL);
                    dypara.Add("@ALLOW_NEW_DEPO", rl.ALLOW_NEW_DEPO);
                    dypara.Add("@ALLOW_NEW_LOAN", rl.ALLOW_NEW_LOAN);
                    dypara.Add("@ALLOW_INT_PARA", rl.ALLOW_INT_PARA);
                    dypara.Add("@ALLOW_VCH", rl.ALLOW_VCH);
                    dypara.Add("@ALLOW_DISBURSE", rl.ALLOW_DISBURSE);
                    dypara.Add("@ALLOW_LN_REPAY", rl.ALLOW_LN_REPAY);
                    dypara.Add("@ALLOW_VCH_AP", rl.ALLOW_VCH_AP);
                    dypara.Add("@ALLOW_DEPO_AP", rl.ALLOW_DEPO_AP);
                    dypara.Add("@ALLOW_LN_AP", rl.ALLOW_LN_AP);
                    dypara.Add("@ALLOW_CR_USR", rl.ALLOW_CR_USR);
                    dypara.Add("@ALLOW_BNK_INFO", rl.ALLOW_BNK_INFO);
                    dypara.Add("@ALLOW_RENEW_EXP", rl.ALLOW_RENEW_EXP);
                    dypara.Add("@ALLOW_VCH_EDIT", rl.ALLOW_VCH_EDIT);
                    dypara.Add("@ALLOW_VCH_EDIT", rl.ALLOW_VCH_EDIT);

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
        public int deleterole(int id)
        {
            throw new NotImplementedException();
        }

        public RoleEntity Roleselect(int id)
        {
            try
            {
                var query = "Usp_UserRole";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "B");
                    dypara.Add("@ROLE_ID", id);
                    var res = Connection.Query<RoleEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res.FirstOrDefault();
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public RoleEntity Rolebind(int id)
        {
            try
            {
                var query = "Usp_UserRole";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "S");
                    dypara.Add("@ROLE_ID", id);
                    var res = Connection.Query<RoleEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res.FirstOrDefault();
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
