using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Account
{
    public class AccountEntity
    {
        public int Account_id { get; set; }
        public int branch_id { get; set; }
        public int accounttype_id { get; set; }
        public string GlOb_Type { get; set; }
        public DateTime GlOb_date { get; set; }
        public double GlOb_Amount { get; set; }
        public string Gl_Status { get; set; }
        public double Lad_Percentage { get; set; }
        public double Penal_Rate { get; set; }


        //Unmapped Property
        public string Branch_Name { get; set; }
        public string GL_NAME { get; set; }
    }
}
