using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.ServerData
{
    public class ServerDateEntity
    {
        public int Server_id { get; set; } = 0;
        public DateTime SERVER_DATE { get; set; }   //DateTime.Now;
        public string STATUS { get; set; } = null;
        public int BRANCH_id { get; set; } = 0;
        public string Branch_Name { get; set; } = null; //Un-Mapped Property from Branch Entity
    }
}
