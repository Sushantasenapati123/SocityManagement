using Bank.Domain.Branch;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Bank.Domain.Customer.CustmerEntity;

namespace Bank.Irepository.Branch
{
    public interface IBranchRepository
    {
        Task<List<BranchEntity>> getbranch();
  
        Task<BranchEntity> GetBranch(int id);
        int AddBranch(BranchEntity br);
        int UpdateBranch(BranchEntity br);
        int DeleteBranch(int id);
    }
}
