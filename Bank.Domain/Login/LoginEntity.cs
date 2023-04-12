using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Login
{
    public class LoginEntity
    {
        public int Id { get; set; }
        public string USER_ID { get; set; }
        public string USER_PASSWORD { get; set; }

        public string adminbranchName { get; set; }
        
        public string ROLE_NAME { get; set; } 
        public string USERROLE { get; set; }
        public string Branch_Name { get; set; }
    }
}
