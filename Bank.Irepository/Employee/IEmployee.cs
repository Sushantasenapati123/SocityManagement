using Bank.Domain.Customer;
using Bank.Domain.EmployeeRegistration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Irepository.Employee
{
   public interface IEmployee
    {
        Task<IEnumerable<EmployeeEntity>> listcustmer(EmployeeEntity cu);

        Task<List<EmployeeEntity>> bindDesigNation();
        int insertEmployee(EmployeeEntity rl);
       
        int deleteEmployee(int id);
        public EmployeeEntity selectEmployee(int id);
      
    }
}
