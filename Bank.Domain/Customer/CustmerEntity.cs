using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Customer
{
    public class CustmerEntity
    {
        public double Totalsaving { get; set; }
        public string Opening_Balance { get; set; }//
        public int CUSTOMER_id { get; set; }
        public int RATE_APPLICABLE { get; set; }
        public Int64 NewAccountNo { get; set; }
        public Int64 Amount { get; set; }
     
        public int Customer_Code { get; set; }
        public string NAME_INITIALS { get; set; }
        public string Account_Type { get; set; }
        
        public string Name { get; set; }
        public string HeadOfAccount { get; set; }
        public string customername { get; set; }
        public string Minimum_Balance { get; set; }
        public string Branch_Name { get; set; }
        public string EnteredByy { get; set; }
        public string IdentificationNo { get; set; }
        public string BranchName { get; set; }

        public int branch_id { get; set; }
        public int trans_id { get; set; }
        public string BranchCode { get; set; }
        public string serverdate { get; set; }
             public string SERVER_DATE { get; set; }
        public string Photo { get; set; }
        public string CUSTOMER_NAME { get; set; } = "";
        public string FATHER_HUSBAND { get; set; }
        public string MOTHER_WIFE { get; set; }
        public string B_REL_1 { get; set; }
        public string B_REL_2 { get; set; }
        public string CASTE { get; set; }
        public string SEX { get; set; }
        public string SENIOR_CITIZEN { get; set; }
        public string OCCUPATION { get; set; }
        public string CUR_ADDRESS_1 { get; set; }
        public string CUR_ADDRESS_2 { get; set; }
        public string CUR_ADDRESS_3 { get; set; }
        public string PIN { get; set; }

        public string CurrentPIN { get; set; }//CurPHONE_NO_1
        public string CurPHONE_NO_1 { get; set; }//CurPHONE_NO_2
        public string CurPHONE_NO_2 { get; set; }//CurPHONE_NO_2


        public string GL_Code { get; set; }//CurPHONE_NO_1
        public string Account_Number { get; set; }//CurPHONE_NO_2
      
        public string Trans_Date { get; set; }


        public string gl_nature { get; set; }
        public string Gl_Type { get; set; }//use  for account type 
        public string GL_NAME { get; set; }
        public string PHONE_NO_1 { get; set; }
        public string PER_PHN_2 { get; set; }
        public string PHONE_NO_2 { get; set; }
        public string PER_ADDRESS_1 { get; set; }
        public string PER_ADDRESS_2 { get; set; }
        public string PER_ADDRESS_3 { get; set; }
        public string PER_PIN { get; set; }
        public string PER_PHN_1 { get; set; }

        public string PAN_NO { get; set; }
        public string DOB { get; set; }
        public string DOM { get; set; }
        public string IS_STAFF { get; set; }
        public string IS_MINOR { get; set; }
        public string DATE_ENROLLED { get; set; }
        public string INTRODUCER_CUSTOMER_id { get; set; }
        public string LEGAL_HAIR_NAME { get; set; }

        public string QUALIFICATION { get; set; }
        public string OCCUPATION_OTHER { get; set; }
        public string SALARIED_WITH { get; set; }
        public string SALARIED_WITH_OTHER { get; set; }
        public string NATURE_OF_BUS { get; set; }
        public string OTHER_NATURE_NAME { get; set; }
        public string DATE_OF_INCORPORATION { get; set; }
        public string TYPE_OF_COMP { get; set; }
        public string TYPE_OF_COMP_OTHER { get; set; }
        public string SELF_EMP_PROFESSIONAL { get; set; }
        public string SELF_EMP_PROFESSIONAL_OTHER { get; set; }
        public string SOURCE_OF_FUNDS { get; set; }
        public string OTHER_SOURCE { get; set; }
        public string ANNUAL_INCOME_1 { get; set; }
        public string ANNUAL_INCOME_2 { get; set; }
        public string RESIDENCE_TYPE { get; set; }
        public string aadharno { get; set; }
        public string idproof { get; set; }
        public string addressproof { get; set; }
        public IFormFile PHOTOSIGNATURE { get; set; }
        public string CREATED_BY { get; set; }
        public string PASSED_BY { get; set; }//Introducer
        public string Introducer { get; set; }
        public string AGE { get; set; }//
        public string Email { get; set; }
        //------paging --------//'/
        public int AddreeProofType { get; set; }
        public string AddreeProofCopy { get; set; }
        /// <summary>
        /// //////////////
        /// 
        /// 
        /// 
        /// </summary>
        /// 
        public string Trans_TimeOfEntry { get; set; }
        public string Credit { get; set; }
        public string From_Date { get; set; }
        public string To_Date { get; set; }


        public int AccountType_id { get; set; }



        public class CustomerModel
        {
            ///<summary>
            /// Gets or sets Customers.
            ///</summary>
            public List<CustmerEntity> Customers { get; set; }

            ///<summary>
            /// Gets or sets CurrentPageIndex.
            ///</summary>
            public int CurrentPageIndex { get; set; }

            ///<summary>
            /// Gets or sets PageCount.
            ///</summary>
            public int PageCount { get; set; }
        }
       
        public class Report1
        {
            //for binding Entity
            public string Account_Type { get; set; }//
            public int Customer_Code { get; set; }//
            public string Trans_TimeOfEntry { get; set; }
            public string Credit { get; set; }
            public string Trans_Date { get; set; }//CurPHONE_NO_2
            public string From_Date { get; set; }
            public string To_Date { get; set; }
            public string CUSTOMER_NAME { get; set; }


            public Int64 Amount { get; set; }
            public int branch_id { get; set; }
            public int BranchCode { get; set; }
            public int AccountType_id { get; set; }
            public string gl_nature { get; set; }
          
            public string GL_NAME { get; set; }

        }
        public class Report
        {
            public string SERVER_DATE { get; set; }
            public Int64 sumdebit { get; set; }
            public Int64 sumcredit { get; set; }
            public string Branch { get; set; }
            //for binding Entity
            public string Account_Type { get; set; }//
            public int Customer_Code { get; set; }//
            public string Trans_TimeOfEntry { get; set; }
            public string Credit { get; set; }
            public string Trans_Date { get; set; }//CurPHONE_NO_2
            public string From_Date { get; set; }
            public string To_Date { get; set; }
            public string CUSTOMER_NAME { get; set; }


            public Int64 Amount { get; set; }
            public int branch_id { get; set; }
            public int BranchCode { get; set; }
            public int AccountType_id { get; set; }
            public string gl_nature { get; set; }
            public string GL_NAME { get; set; }



            public string Name { get; set; }

            public string ApproveDate { get; set; }
            public string Status { get; set; }

            public Int64 NewAccountNo { get; set; }
            public int Balance { get; set; }

        }
    }
}
