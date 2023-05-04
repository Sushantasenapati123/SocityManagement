using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Bank.Domain.AccountOpening
{
    public class AccountopeningEntity
    {
        //for binding Entity
        public string Agent_Code { get; set; }
        public int Openingdetails_id { get; set; }//
        public double Totalsaving { get; set; }
        public string Voucher_No { get; set; }
        public int LoanAmount { get; set; }

        public int Customer_Code { get; set; }
        public string Userid { get; set; }
        public int branch_id { get; set; }
        public string Branch_Name { get; set; }
      

        public string HeadOfAccount { get; set; }
        public string BranchCode { get; set; }

        public string Currentbal { get; set; }

        public string Opening_Balance { get; set; }
        public string Minimum_Balance { get; set; }

        public string Seniorcitizen { get; set; }
        public string customername { get; set; }
        public string Account_Number { get; set; }
        public string Certificateno { get; set; }
        public string staff { get; set; }
        public Int64 Accountno { get; set; }
        public string Sex { get; set; }
        public string Caste { get; set; }
        public string Presentaddress { get; set; }
        public string Permanentaddress { get; set; }
        public string Modeofoperation { get; set; }
        public int Amount { get; set; }
        public DateTime OpeningDATE { get; set; }
        public int LoanFixDepositeEndDate { get; set; }///use for carrying Loan Year in Number
        public string LoanFixDepositeEndDate1 { get; set; }///use for carrying Fisdeposite End Year in DateFormat
        public int LoanPaybleAmount { get; set; }
        public int FixdepositeMaturityAmount { get; set; }
        public string GL_NAME { get; set; }
        public string Facevalue { get; set; }
        public string NoUnint { get; set; }
        public string Enterancefee {get;set;}

        public string IntroducerPresentaddress {get;set;}
        public string serverdate { get; set; }
        public string Nomineename1 { get; set; }
        public string Nomineerelation1 { get; set; }
        public string Nomineeaddress1st1 { get; set; }
        public string Nomineeaddress2nd1 { get; set; }
        public string Nomineeaddress3rd1 { get; set; }
        public string pincode1 { get; set; }
        public string phone1 { get; set; }
        public string Altphone1 { get; set; }

        public string Minimumbal1 { get; set; }
        public string Status1 { get; set; }

        //public string Presentaddress { get; set; }
        public string Nomineename2 { get; set; }
        public string Nomineerelation2 { get; set; }
        public string Nomineeaddress1st2 { get; set; }
        public string Nomineeaddress2nd2 { get; set; }
        public string Nomineeaddress3rd2 { get; set; }
        public string pincode2 { get; set; }
        public string phone2 { get; set; }
        public string Altphone2 { get; set; }

        public string Minimumbal2 { get; set; }
        public string Status2 { get; set; }

        //public string Presentaddress { get; set; }
        public string Nomineename3 { get; set; }
        public string Nomineerelation3 { get; set; }
        public string Nomineeaddress1st3 { get; set; }
        public string Nomineeaddress2nd3 { get; set; }
        public string Nomineeaddress3rd3 { get; set; }
        public string pincode3 { get; set; }
        public string phone3 { get; set; }
        public string Altphone3 { get; set; }

        public string Minimumbal3 { get; set; }
        public string Status3 { get; set; }




    }
    public class fillddl
    {
        //for binding Entity
        public int Openingdetails_id { get; set; }//
        public string HeadOfAccount { get; set; }//Accountno
        public Int64 Accountno { get; set; }
        

    }
    public class BankTransfer
    {
        public string From { get; set; }
        public int Amount { get; set; }
    }
    public class Approve
    {
        public int Status { get; set; }
        public int id { get; set; }
        public int AmountFromBank { get; set; }
        public DateTime Trans_Date { get; set; }
        public string Particular { get; set; }
        public string Voucher_Type { get; set; }
        public string HeadOfAccount { get; set; }
        public string CustomerName { get; set; }
        public Int64 Accountno { get; set; }



        public List<BankTransfer> CollectionBank { get; set; }
    }
    public class VoucherinsXML
    {
        public XDocument ApproveXML { get; set; }

    }

}
