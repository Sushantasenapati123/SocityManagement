using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.User
{
    public class UserEntity
    {
        public int ID { get; set; }
        public string USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_PASSWORD { get; set; }
        public string CONFIRM_PASSWORD { get; set; }
        public DateTime FROM_DATE { get; set; }
        public DateTime TO_DATE { get; set; }

        public string USER_STATUS { get; set; }
        public int ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string USER_EMAIL { get; set; }
        public string USER_MOBILE { get; set; }

        public int BRANCH_id { get; set; }

        public string Branch_Name { get; set; }
    }
}
