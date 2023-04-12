using Bank.Domain.ServerData;
using Bank.Irepository.Role;
using Dapper;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.SerVerData
{
    public class ServerDateRepository : RepositoryBase, IServerDateRepository
    {
        public ServerDateRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public int AddServerDate(ServerDateEntity sdEntity)
        {
            try
            {
                var query = "USP_ServerDate";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@SERVER_DATE", sdEntity.SERVER_DATE);
                    dypara.Add("@STATUS", sdEntity.STATUS);
                    dypara.Add("@BRANCH_id", sdEntity.BRANCH_id);
                    dypara.Add("@Action", "I");
                    dypara.Add("pmsg", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    var cc = Convert.ToInt32(dypara.Get<String>("pmsg"));
                    return cc;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<ServerDateEntity>> GetServerDate()
        {
            {
                try
                {
                    var query = "USP_ServerDate";
                   

                        var dypara = new DynamicParameters();
                        dypara.Add("@Action", "S");
                        var res = await Connection.QueryAsync<ServerDateEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                        return res;
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public async Task<ServerDateEntity> GetDate(int id)
        {
            try
            {
                var query = "USP_ServerDate";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Server_id", id);
                    dypara.Add("@Action", "SI");
                    var res = await Connection.QueryFirstOrDefaultAsync<ServerDateEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateServerDate(ServerDateEntity sdEntity)
        {
            try
            {
                var query = "USP_ServerDate";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Server_id", sdEntity.Server_id);
                    dypara.Add("@SERVER_DATE", sdEntity.SERVER_DATE);
                    dypara.Add("@STATUS", sdEntity.STATUS);
                    dypara.Add("@BRANCH_id", sdEntity.BRANCH_id);
                    dypara.Add("@Action", "U");
                    dypara.Add("pmsg", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    var cc = Convert.ToInt32(dypara.Get<String>("pmsg"));
                    return cc;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteServerDate(int id)
        {
            try
            {
                var query = "USP_ServerDate";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@Server_id", id);
                    dypara.Add("@Action", "D");
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<ServerDateEntity>> listBranch()
        {
            {
                try
                {
                    var query = "USP_ServerDate";
                   

                        var dypara = new DynamicParameters();
                        dypara.Add("@Action", "SB");
                        var res = await Connection.QueryAsync<ServerDateEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                        return res;
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public async Task<ServerDateEntity> GetByBranch(int id)
        {
            try
            {
                var query = "USP_ServerDate";
               
                    var dypara = new DynamicParameters();
                    dypara.Add("@BRANCH_id", id);
                    dypara.Add("@Action", "SD");
                    var res = await Connection.QueryFirstOrDefaultAsync<ServerDateEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
