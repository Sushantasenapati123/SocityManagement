using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Branch
{
    public class BranchEntity
    {
        public int branch_id { get; set; } = 0;

        public string branch_Code { get; set; } = null;
        public string Branch_Name { get; set; } = null;

        public string Branch_address { get; set; } = null;
        public string photosignature { get; set; } = null;
        
        

    }
   
}