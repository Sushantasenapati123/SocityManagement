using Bank.Domain.EmployeeRegistration;
using Bank.Irepository.Employee;
using Dapper;
using MiniBankingSystem.IRepository.Factory;
using PathoLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.Employee
{
   public class EmployeeRepo : RepositoryBase, IEmployee
    {
        public EmployeeRepo(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public int insertEmployee(EmployeeEntity cust)
        {
            try
            {
                var query = "Usp_Employee";

                var dypara = new DynamicParameters();
                if(cust.Eid!=0)
                    dypara.Add("@Action", "U");
                else
                   dypara.Add("@Action", "I");
                dypara.Add("@Eid", cust.Eid);
                dypara.Add("@EmployeeName", cust.EmployeeName);
                dypara.Add("@DesgId", cust.DesgId);
                dypara.Add("@branch_id", cust.branch_id);
                dypara.Add("@DateOfJoin", cust.DateOfJoin);
                dypara.Add("@EmployeeType", cust.EmployeeType);
                dypara.Add("@RoleId", cust.RoleId);
                dypara.Add("@Photo", cust.Photo);
              
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
        public EmployeeEntity custmerbind(int id)
        {
            throw new NotImplementedException();
        }

        public EmployeeEntity selectEmployee(int id)
        {
            try
            {
                var query = "Usp_Employee";

                var dypara = new DynamicParameters();
                dypara.Add("@action", "O");
                dypara.Add("@Eid", id);
                var res = Connection.Query<EmployeeEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deleteEmployee(int id)
        {
            try
            {
                var query = "Usp_Employee";


                var dypara = new DynamicParameters();
                dypara.Add("@Action", "D");
                dypara.Add("@Eid", id);
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


        public async Task<IEnumerable<EmployeeEntity>> listcustmer(EmployeeEntity cu)
        {
            try
            {
                var query = "Usp_Employee";
                //if (cu.DesgId == null)
                //    cu.DesgId = "";
                var dypara = new DynamicParameters();
                dypara.Add("@DesgId", cu.DesgId);
                dypara.Add("@action", "S");

                var res = Connection.Query<EmployeeEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<EmployeeEntity>> bindDesigNation()
        {
            try
            {
                var query = "Usp_Employee";
                
                var dypara = new DynamicParameters();
                
                dypara.Add("@action", "BindDesig");

                var res = Connection.Query<EmployeeEntity>(query, dypara, commandType: CommandType.StoredProcedure);
                return res.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}