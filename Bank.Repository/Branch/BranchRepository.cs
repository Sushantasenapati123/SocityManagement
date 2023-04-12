using Bank.Domain.Branch;
using Bank.Irepository.Branch;
using Dapper;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank.Domain.Customer.CustmerEntity;

namespace Bank.Repository.Branch
{
    public class BranchRepository : RepositoryBase, IBranchRepository
    {
        public BranchRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public int AddBranch(BranchEntity br)
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
                Connection.Open();


                var query = "Usp_Branch_Details";
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "I");
                    dypara.Add("@Branch_Name", br.Branch_Name);
                    dypara.Add("@Branch_address", br.Branch_address);
                    dypara.Add("@photosignature", br.photosignature);

                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteBranch(int id)
        {
            try
            {
                var query = "Usp_Branch_Details";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "D");
                    dypara.Add("@branch_id", id);
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<BranchEntity>> getbranch()
        {
            try
            {
                var query = "Usp_Branch_Details";
              

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "S");
                    var res = await Connection.QueryAsync<BranchEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res.ToList();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public async Task<BranchEntity> GetBranch(int id)
        {
            try
            {      

                    var query = "Usp_Branch_Details";
                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "O");
                    dypara.Add("@branch_id", id);
                    var res = await Connection.QueryFirstOrDefaultAsync<BranchEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateBranch(BranchEntity br)
        {
            try
            {
                var query = "Usp_Branch_Details";
               

                    var dypara = new DynamicParameters();
                    dypara.Add("@Action", "U");
                    dypara.Add("@branch_id", br.branch_id);
                    dypara.Add("@Branch_Name", br.Branch_Name);
                    dypara.Add("@Branch_address", br.Branch_address);
                    dypara.Add("@photosignature", br.photosignature);
                    int res = Connection.Execute(query, dypara, commandType: CommandType.StoredProcedure);
                    return res;
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
