using Bank.Domain.GlGroup;
using Bank.Irepository.GlGroup;
using Dapper;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.GlGroup
{
    public class GlgroupRepository : RepositoryBase, IglgroupRepository
    {
        public GlgroupRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public int insertgroup(GlgroupEntity rl)
        {
            try
            {
                var query = "USP_glgroup";

                var dypara = new DynamicParameters();
                dypara.Add("@Action", "I");
                dypara.Add("@grouptype_id", rl.grouptype_id);
                dypara.Add("@GlGroup_name", rl.GlGroup_name);
                dypara.Add("@GlGroup_code", rl.GlGroup_code);
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

        public List<GlgroupEntity> listrgroup()
        {
            try
            {
                var query = "USP_glgroup";

                //Connection.Open();
                var dypara = new DynamicParameters();
                dypara.Add("@Action", "A");
                var res = Connection.Query<GlgroupEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                // con.Close();
                return res.AsList();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<GlgroupEntity> groupselect(int id)
        {
            try
            {
                var query = "USP_glgroup";


                var dypara = new DynamicParameters();
                dypara.Add("@Action", "S");
                dypara.Add("@GlGroup_id", id);
                //var res = Connection.Query<GlgroupEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                var res = await Connection.QueryFirstOrDefaultAsync<GlgroupEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int updatgroupl(GlgroupEntity rl)
        {

            try
            {
                var query = "USP_glgroup";

                var dypara = new DynamicParameters();
                dypara.Add("@Action", "U");
                dypara.Add("@GlGroup_id", rl.GlGroup_id);
                dypara.Add("@grouptype_id", rl.grouptype_id);
                dypara.Add("@GlGroup_name", rl.GlGroup_name);
                dypara.Add("@GlGroup_code", rl.GlGroup_code);

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
        public int deletegroup(int id)
        {
            throw new NotImplementedException();
        }
        public List<GlgroupEntity> glgroupbind()
        {
            try
            {
                var query = "USP_glgroup";

                //con.Open();
                var dypara = new DynamicParameters();
                dypara.Add("@Action", "B");
                var res = Connection.Query<GlgroupEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                //        con.Close();
                return res.AsList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //public async Task<IEnumerable<GlgroupEntity>> Selectone(int grouptype_id)
        //{
        //    try
        //    {
        //        GlgroupEntity at = new GlgroupEntity();
        //        var query = "USP_glgroup";
        //        using (var con = _ConnectionClass.getCon)
        //        {
        //            var dypara = new DynamicParameters();
        //            dypara.Add("@Grouptype_id", grouptype_id);
        //            dypara.Add("@Action", "L");
        //            dypara.Add("PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
        //            var result = await con.QueryAsync<GlgroupEntity>(query, dypara, commandType: CommandType.StoredProcedure);
        //            var cc = Convert.ToInt32(dypara.Get<String>("PMSGOUT")).ToString();

        //            return cc;
        //        }
        //    }


        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public int Selectone(int grouptype_id)
        {
            try
            {
                var query = "USP_glgroup";


                var dypara = new DynamicParameters();
                dypara.Add("@Action", "L");
                dypara.Add("@Grouptype_id", grouptype_id);
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


    }
}
