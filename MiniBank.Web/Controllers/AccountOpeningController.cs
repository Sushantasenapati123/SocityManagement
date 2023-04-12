using Bank.Domain.AccountOpening;
using Bank.Domain.Branch;
using Bank.Domain.Customer;
using Bank.Irepository.AccountingOpening;
using Bank.Irepository.Branch;
using Bank.Irepository.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Bank.Domain.Customer.CustmerEntity;

namespace MiniBank.Web.Controllers
{
    public class AccountOpeningController : Controller
    {
        private readonly IAccountopeningRepository _IAccountopeningRepository;
        private readonly ICustmerRepository _cost;
        private readonly IBranchRepository _Branch;
        public AccountOpeningController(IAccountopeningRepository IAR, ICustmerRepository cost, IBranchRepository Branch)
        {
            _IAccountopeningRepository = IAR;
            _cost = cost;
            _Branch = Branch;
        }
        [HttpGet]
        public IActionResult insertpage(string id = null)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            var X = _IAccountopeningRepository.getdetails(id);
            // ViewBag.USERID = X.Result.branch_id;
            return View();
        }
        [HttpPost]
        public IActionResult insertpage(AccountopeningEntity empObj)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            empObj.BranchCode = HttpContext.Session.GetString("Branch");
            empObj.Userid = HttpContext.Session.GetString("Userid");

            empObj.OpeningDATE = Convert.ToDateTime(empObj.OpeningDATE);
            var Retval = _IAccountopeningRepository.AddAccount(empObj);
            return Ok(Retval);

        }
        [HttpGet]
        public IActionResult DepositeAmount()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            //var X = _IAccountopeningRepository.getdetails(id);
            // ViewBag.USERID = X.Result.branch_id;
            return View();
        }
        [HttpGet]
        public IActionResult WithdrowAmount()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            //var X = _IAccountopeningRepository.getdetails(id);
            // ViewBag.USERID = X.Result.branch_id;
            return View();
        }




        [HttpGet]
        public IActionResult ViewpendingAccountDetailsByFrontoffice(string id = null)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            var X = _IAccountopeningRepository.getdetails(id);
            // ViewBag.USERID = X.Result.branch_id;
            return View();
        }

        [HttpGet]
        public IActionResult Loaninsertpage(string id = null)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            var X = _IAccountopeningRepository.getdetails(id);
            // ViewBag.USERID = X.Result.branch_id;
            return View();
        }
        [HttpGet]
        public IActionResult Fixdeposit_insertpage(string id = null)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            var X = _IAccountopeningRepository.getdetails(id);
            //ViewBag.USERID = X.Result.branch_id;
            return View();
        }
        [HttpGet]
        public IActionResult Fixdeposit_insertpageForViewByAdmin(string id = null)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            var X = _IAccountopeningRepository.getdetails(id);
            // ViewBag.USERID = X.Result.branch_id;
            return View();
        }
        [HttpGet]
        public IActionResult Fixdeposit_insertpage2(string id = null)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            var X = _IAccountopeningRepository.getdetails(id);
            // ViewBag.USERID = X.Result.branch_id;
            return View();
        }
        public IActionResult index(string id = null)
        {
            // ViewBag.USER_ID = id;
            var X = _IAccountopeningRepository.getdetails(id);
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Branch = HttpContext.Session.GetString("Branch");

            // ViewBag.USERID = X.Result.branch_id;
            return View();
        }
        [HttpPost]
        public JsonResult AutoComplete(string prefix)
      {
            var prescription = (from Prescription in _IAccountopeningRepository.AutoCompleteBankName().Result
                                where Prescription.gl_nature.ToUpper().StartsWith(prefix.ToUpper())
                                select new
                                {
                                    label = Prescription.gl_nature,
                                    val = Prescription.AccountType_id
                                }).ToList();

            return Json(prescription);
        }
        [HttpGet]
        public IActionResult GetGLcodeByGLName(string BankNAme)
            {
            var labTest = _IAccountopeningRepository.GetGLcodeByGLName(BankNAme).Result;
            if (labTest != null)
            {
                return Ok(JsonConvert.SerializeObject(labTest.gl_code));
            }
            else
            {
                return Ok("");
            }
        }

       
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }



        //public IActionResult ApprovedCustomerAccount(int id,int Status,DateTime Trans_Date, string Particular,string Voucher_Type,List<BankTransfer> CollectionBank)
        public IActionResult ApprovedCustomerAccount(Approve entity)

        {
            //string myIP = GetLocalIPAddress();
            //DateTime dt = entity.Trans_Date;
            //string trntime = dt.ToString("hh:mm tt");
            //int AmountFromBank = 0;

            //List<Approve> ilist = new List<Approve>();
            //var xEle = new XDocument();
            //var dec = new XDeclaration("1.0", "UTF-8", "yes");
            //xEle.Declaration = dec;
            //xEle.Add(new XElement("person",
            //                          from lan in ilist
            //                          select new XElement("row",
            //                                         new XElement("HeadOfAccount", lan.HeadOfAccount),
            //                                         new XElement("AmountFromBank", lan.AmountFromBank),
            //                                         new XElement("Trans_Date", lan.Trans_Date),
            //                                         new XElement("Trans_TimeOfEntry", trntime),

            //                                         new XElement("Particular", lan.Particular),
            //                                         new XElement("Voucher_Type", lan.Voucher_Type),
            //                                         new XElement("Scroll_Terminal_Code", myIP),
            //                                         new XElement("Approved_By", HttpContext.Session.GetString("Userid")),
            //                                           new XElement("Openingdetails_id", lan.id)

            //                                     )));
            //VoucherinsXML isx = new VoucherinsXML();
            //isx.ApproveXML = xEle;



            ////    var Retval = _IAccountopeningRepository.ApprovedCustomer(entity.id, entity.Status, HttpContext.Session.GetString("Userid"), entity.Trans_Date, entity.Particular, entity.Voucher_Type, trntime, myIP, entity.HeadOfAccount, AmountFromBank);
            ////    return Ok(Retval);

            //var Retval = _IAccountopeningRepository.ApprovedCustomer(entity.id, entity.Status, HttpContext.Session.GetString("Userid"), entity.Trans_Date, entity.Particular, entity.Voucher_Type, trntime, myIP, entity.HeadOfAccount, AmountFromBank);

              if (entity.Voucher_Type == "Cash")
            {
                string myIP = GetLocalIPAddress();
                DateTime dt = entity.Trans_Date;
                string trntime = dt.ToString("hh:mm tt");
                int AmountFromBank = 0;
                var Retval = _IAccountopeningRepository.ApprovedCustomer(entity.id, entity.Status, HttpContext.Session.GetString("Userid"), entity.Trans_Date, entity.Particular, entity.Voucher_Type, trntime, myIP, entity.HeadOfAccount, AmountFromBank, HttpContext.Session.GetString("Branch"));
                return Ok(Retval);
            }
            else
            {
                string myIP = GetLocalIPAddress();
                DateTime dt = entity.Trans_Date;
                string trntime = dt.ToString("hh:mm tt");
                int AmountFromBank = 0;
                var Retval = _IAccountopeningRepository.ApprovedCustomer(entity.id, entity.Status, HttpContext.Session.GetString("Userid"), entity.Trans_Date, entity.Particular, entity.Voucher_Type, trntime, myIP, entity.HeadOfAccount, AmountFromBank, HttpContext.Session.GetString("Branch"));
                if(entity.CollectionBank!=null)
                        {
                    foreach (var Bank in entity.CollectionBank)
                    {
                        entity.HeadOfAccount = Bank.From;
                        entity.AmountFromBank = Bank.Amount;
                        int retMsgPM = _IAccountopeningRepository.ApprovedCustomer(entity.id, entity.Status, HttpContext.Session.GetString("Userid"), entity.Trans_Date, entity.Particular, entity.Voucher_Type, trntime, myIP, entity.HeadOfAccount, entity.AmountFromBank, HttpContext.Session.GetString("Branch"));
                    }
                }
                
                return Ok(Retval);
            }


        }


        public IActionResult ViewAccountDetails(AccountopeningEntity empObj)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            var Retval = _IAccountopeningRepository.AddAccount(empObj);
            return View();

        }
        /// <summary>
        /// ///////////////////////
        /// </summary>
        /// <param name="empObj"></param>
        /// <returns></returns>
        public IActionResult ViewAccountDetailsByAdmin(AccountopeningEntity empObj)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
           //var Retval = _IAccountopeningRepository.AddAccount(empObj);
            return View();

        }
        /// <summary>
        /// //////////
        /// </summary>
        /// <returns></returns>


        public async Task<IActionResult> ViewCustomerForACOpening()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Result = await _cost.listcustmer(new CustmerEntity());
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ViewCustomerForACOpening(CustmerEntity d)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Result = await _cost.listcustmer(d);
            return View();
        }

        public async Task<IActionResult> ViewBranchWiseCustomer()
        {
            List<BranchEntity> pc5 = new List<BranchEntity>();
            pc5 = await _Branch.getbranch();
            pc5.Insert(0, new BranchEntity { branch_id = 0, Branch_Name = "---Select---" });
            ViewBag.Branch = pc5;

            List<Report> pc6 = new List<Report>();
            pc6 = (List<Report>)await _cost.getAccountType();
           // pc6.Insert(0, new Report { AccountType_id = 0, gl_nature = "---Select---" });
            ViewBag.Account = pc6;

            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Branchn = HttpContext.Session.GetString("Branch");
            ViewBag.Result = await _cost.listcustmerBranchWise(new CustmerEntity());
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ViewBranchWiseCustomer(CustmerEntity d)
        {
            List<BranchEntity> pc5 = new List<BranchEntity>();
            pc5 = await _Branch.getbranch();
            pc5.Insert(0, new BranchEntity { branch_id = 0, Branch_Name = "Select" });
            ViewBag.Branch = pc5;

            List<Report> pc6 = new List<Report>();
            pc6 = (List<Report>)await _cost.getAccountType();
            //pc6.Insert(0, new Report { AccountType_id = 0, gl_nature = "---Select---" });
            ViewBag.Account = pc6;


            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Branchn = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.listcustmerBranchWise(d);
            return View();
        }

        public async Task<IActionResult> ViewPendingCustomer()
        {
            List<BranchEntity> pc5 = new List<BranchEntity>();
            pc5 = await _Branch.getbranch();
            pc5.Insert(0, new BranchEntity { branch_id = 0, Branch_Name = "Select" });
            ViewBag.Branch = pc5;
           
            HttpContext.Session.SetString("Approved", "Approved");
            AccountopeningEntity cu = new AccountopeningEntity();
            cu.Branch_Name= HttpContext.Session.GetString("Branch");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Branchn = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.listPendingcustmer(cu);
            return View();
        }
        public async Task<IActionResult> ViewPendingCustomerDetails()
        {
            List<BranchEntity> pc5 = new List<BranchEntity>();
            pc5 = await _Branch.getbranch();
            pc5.Insert(0, new BranchEntity { branch_id = 0, Branch_Name = "Select" });
            ViewBag.Branch = pc5;

           
            AccountopeningEntity cu = new AccountopeningEntity();
            cu.Branch_Name = HttpContext.Session.GetString("Branch");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Branchn = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.listPendingcustmer(cu);
            return View();
        }
        public async Task<IActionResult> ViewAppprovedCustomer()
        {
            List<BranchEntity> pc5 = new List<BranchEntity>();
            pc5 = await _Branch.getbranch();
            pc5.Insert(0, new BranchEntity { branch_id = 0, Branch_Name = "Select" });
            ViewBag.Branch = pc5;

            AccountopeningEntity cu = new AccountopeningEntity();
            cu.Branch_Name = HttpContext.Session.GetString("Branch");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Branchn = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.listApprovedcustmer(cu);
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Viewallaccountballance()
        {
            AccountopeningEntity cu = new AccountopeningEntity();
            cu.Branch_Name = HttpContext.Session.GetString("Branch");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Branchn = HttpContext.Session.GetString("Branch");
            ViewBag.Result = await _IAccountopeningRepository.Viewallaccountballance(456);


            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Viewallaccountballance(int Customer_Code)
        {

            AccountopeningEntity cu = new AccountopeningEntity();
            cu.Branch_Name = HttpContext.Session.GetString("Branch");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Branchn = HttpContext.Session.GetString("Branch");
            //ViewBag.Result = await _cost.listApprovedcustmer(cu);

            ViewBag.Result = await _IAccountopeningRepository.Viewallaccountballance(Customer_Code);
            return View();
        }



        public async Task<IActionResult> ViewCustomerAfterACOpening()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Res = await _IAccountopeningRepository.ViewAccountOpendedCustomer(new AccountopeningEntity());
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ViewCustomerAfterACOpening(AccountopeningEntity d)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Res = await _IAccountopeningRepository.ViewAccountOpendedCustomer(d);
            return View();
        }

        [HttpPost]
        public IActionResult Deletecustomer(int id)
        {
            try
            {
                int Result = _IAccountopeningRepository.deletecustmer(id);
                return Ok(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        [HttpGet]
        public IActionResult GetByIdCustomer(int id)
        {
            var Departments = _IAccountopeningRepository.custmerselect(Convert.ToInt32(id));
            return Ok(JsonConvert.SerializeObject(Departments));
        }


        [HttpGet]
        public IActionResult BindShearDetails(int id)
        {
          
            var Departments = _IAccountopeningRepository.BindShearDetails(Convert.ToInt32(id), HttpContext.Session.GetString("Branch"));
            return Ok(JsonConvert.SerializeObject(Departments));
        }


        [HttpGet]
        public IActionResult ViewAccountDetailsById(int id)
        {
            ViewBag.Approved = HttpContext.Session.GetString("Approved");
            var Departments = _IAccountopeningRepository.ViewAccountDetailsById(Convert.ToInt32(id));
            return Ok(JsonConvert.SerializeObject(Departments));
        }
        [HttpGet]
        public IActionResult get_last_tblvoucherrecord()
        {
            
            var Departments = _IAccountopeningRepository.get_last_tblvoucherrecord();
            return Ok(JsonConvert.SerializeObject(Departments));
        }

        [HttpGet]
        public IActionResult BindDdlForaccount(int id)
        {
            var Departments = _IAccountopeningRepository.BindDdlForaccount(Convert.ToInt32(id), HttpContext.Session.GetString("Branch"));
            return Ok(JsonConvert.SerializeObject(Departments));
        }
        [HttpGet]
        public IActionResult BindDdlForpendingaccount(int id)
        {
            var Departments = _IAccountopeningRepository.BindDdlForPendingaccount(Convert.ToInt32(id));
            return Ok(JsonConvert.SerializeObject(Departments));
        }
       




    }
}
