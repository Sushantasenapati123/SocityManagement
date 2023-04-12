using Bank.Domain.Group;
using Bank.Irepository.Group;
using Dapper;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.Group
{
    public class GroupRepository : RepositoryBase, IGroupRepository
    {
        public GroupRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public int AddGroup(group_entity gr)
        {
            try
            {
                var query = "USP_grouptype";
                

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "I");
                    dypara.Add("@grouptype_name", gr.grouptype_name);
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
        public int DeleteGroup(int id)
        {
            try
            {
                var query = "USP_grouptype";
                
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "D");
                    dypara.Add("@Grouptype_id", id);
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<group_entity>> getgroups()
        {
            try
            {
                var query = "USP_grouptype";
                

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "S");
                    var res = await Connection.QueryAsync<group_entity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateGroup(group_entity gr)
        {
            try
            {
                var query = "USP_grouptype";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "U");
                    dypara.Add("@Grouptype_id", gr.Grouptype_id);
                    dypara.Add("@grouptype_name", gr.grouptype_name);
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
        public async Task<group_entity> GetGroup(int id)
        {
            try
            {
                var query = "USP_grouptype";
                
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "SO");
                    dypara.Add("@Grouptype_id", id);
                    var res = await Connection.QueryFirstOrDefaultAsync<group_entity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
