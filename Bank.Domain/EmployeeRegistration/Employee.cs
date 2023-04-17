using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.EmployeeRegistration
{
  public  class EmployeeEntity
    {
        public int Eid { get; set; }
        public string EmployeeName { get; set; }
      
        public string branch_id { get; set; }
        public int DesgId { get; set; }

        public int ROLE_ID { get; set; }
        //public string Designation { get; set; }

        public string DateOfJoin { get; set; }
        public string EmployeeType { get; set; }
        public int RoleId { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public string DesgName { get; set; }
        public string ROLE_NAME { get; set; }

    }
}
