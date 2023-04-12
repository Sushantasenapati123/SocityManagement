using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.GlGroup
{
    public class GlgroupEntity
    {
        public int GlGroup_id { get; set; }
        public int grouptype_id { get; set; }
        public string GlGroup_code { get; set; }
        public string GlGroup_name { get; set; }
        public List<GlgroupEntity> GlGrouplist { get; set; }
        //for bind//
        public string grouptype_name { get; set; }
    }
}
