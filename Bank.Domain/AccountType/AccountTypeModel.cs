using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.AccountType
{
    public class AccountTypeModel
    {
        public int AccountType_id { get; set; }
        public string GlGroup_code { get; set; }
        public string gl_code { get; set; }
        public string gl_nature { get; set; }
        public string GL_NAME { get; set; }
        public string GlGroup_name { get; set; }
        public int grouptype_id { get; set; }
    }

}
