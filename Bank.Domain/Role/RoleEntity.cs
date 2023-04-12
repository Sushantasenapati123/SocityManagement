using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Role
{
	public class RoleEntity
	{
		public int ROLE_ID { get; set; }
		public string ROLE_NAME { get; set; }
		public string ALLOW_GL { get; set; }
		public string ALLOW_CC { get; set; }
		public string ALLOW_EC { get; set; }
		public string ALLOW_AC { get; set; }
		public string ALLOW_SPCL { get; set; }
		public string ALLOW_NEW_DEPO { get; set; }
		public string ALLOW_NEW_LOAN { get; set; }
		public string ALLOW_INT_PARA { get; set; }
		public string ALLOW_VCH { get; set; }
		public string ALLOW_DISBURSE { get; set; }
		public string ALLOW_LN_REPAY { get; set; }
		public string ALLOW_VCH_AP { get; set; }
		public string ALLOW_DEPO_AP { get; set; }
		public string ALLOW_LN_AP { get; set; }
		public string ALLOW_CR_USR { get; set; }
		public string ALLOW_BNK_INFO { get; set; }
		public string ALLOW_RENEW_EXP { get; set; }
		public string ALLOW_VCH_EDIT { get; set; }
		public List<RoleEntity> Rolelist { get; set; }
	}
}
