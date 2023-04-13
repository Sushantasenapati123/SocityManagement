﻿using Bank.Domain.Branch;
using Bank.Domain.Customer;
using Bank.Irepository.Branch;
using Bank.Irepository.Customer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static Bank.Domain.Customer.CustmerEntity;

namespace MiniBank.Web.Controllers
{
    public class CustmerController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ICustmerRepository _cost;
        private readonly IBranchRepository _Branch;
        public CustmerController(ICustmerRepository cost, IWebHostEnvironment environment, IBranchRepository Branch)
        {
            _cost = cost;
            _environment = environment;
            _Branch = Branch;
        }
        public IActionResult Index()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            return View();
        }
        [HttpGet]
        public IActionResult customerinsert()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Button = "Registation";
            return View();
        }
        [HttpGet]
        public IActionResult customerDetailsView ()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Button = "Registation";
            return View();
        }
        [HttpGet]
        public IActionResult customerDetailsViewByFrontOffice()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Button = "Registation";
            return View();
        }
        [HttpGet]
        public IActionResult ApprovecustomerDetailsView()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Button = "Registation";
            return View();
        }
        public IActionResult ApprovedCustomer(int id,int status)
        {
            var Retval = _cost.ApprovedCustomer(id, HttpContext.Session.GetString("Userid"),status);
            return Ok(Retval);

        }
        public IActionResult ChangeBranchByAdmin(int branchid)
        {
            if(branchid==2)
                HttpContext.Session.SetString("Branch", "Kalpana");
            else
                HttpContext.Session.SetString("Branch", "Khordha");

            var Retval = _cost.ChangeBranchByAdmin(branchid, HttpContext.Session.GetString("Userid"));
            return Ok(Retval);

        }
        [HttpPost]
        public IActionResult UploadImage(IFormFile MyUploader)
        {
            if (MyUploader != null )
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, "prodimage");

                string filePath = Path.Combine(uploadsFolder, MyUploader.FileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    MyUploader.CopyTo(fileStream);
                }
               
                return new ObjectResult(new { status = "success" });
            }
            return new ObjectResult(new { status = "fail" });

        }
       
        [HttpPost]
        public IActionResult UploadAadhar(IFormFile MyUploaderadh)
        {
            if (MyUploaderadh != null)
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, "AddressImage");
                string filePath = Path.Combine(uploadsFolder, MyUploaderadh.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    MyUploaderadh.CopyTo(fileStream);
                }
                return new ObjectResult(new { status = "success" });
            }
            return new ObjectResult(new { status = "fail" });

        }
        [HttpPost]
        public async Task<JsonResult> customerinsert(CustmerEntity custe)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            string[] files = custe.Photo.Split('\\');
            custe.Photo = "prodimage/" + files[files.Length - 1];
            if(custe.AddreeProofCopy!=null)
            {
                string[] address = custe.AddreeProofCopy.Split('\\');
                custe.AddreeProofCopy = "AddressImage/" + address[files.Length - 1];

            }
            custe.Branch_Name= HttpContext.Session.GetString("Branch");
            custe.EnteredByy= HttpContext.Session.GetString("Userid");
            int retMsg = _cost.insertcustmer(custe);

            if (retMsg == 1)
            {
                return Json("Record Saved Successfully");
            }
            else if (retMsg == 2)
            {
                return Json("Record Updated Successfully");
            }
            else if (retMsg == 3)
            {
                return Json("Record Deleted Successfully");
            }
            else
            {
                return Json("Record Already Exist");
            }


            
        }
        [HttpPost]
        public async Task<JsonResult> insertsavingAmount(CustmerEntity custe)
        {
           
            custe.Branch_Name = HttpContext.Session.GetString("Branch");
            custe.EnteredByy = HttpContext.Session.GetString("Userid");
            int retMsg = _cost.insertsavingAmount(custe);

            if (retMsg == 134)
            {
                return Json("Record Saved Successfully");
            }
           
            else
            {
                return Json("Error");
            }



        }
        public async Task<IActionResult> ViewCustomer()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name= HttpContext.Session.GetString("Branch");
            
            ViewBag.Result = await _cost.listcustmer(CN);
            return View();
        }
        public async Task<IActionResult> ViewPendingCustomer()///pending Account
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.listcustmer(CN);
            return View();
        }
        public async Task<IActionResult> ViewReport()//by admin
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name = HttpContext.Session.GetString("Branch");

            List<BranchEntity> pc5 = new List<BranchEntity>();
            pc5 = await _Branch.getbranch();
            pc5.Insert(0, new BranchEntity { branch_id = 0, Branch_Name = "---Select---" });
            ViewBag.Branch = pc5;

            List<Report> pc6 = new List<Report>();
            pc6 = (List<Report>)await _cost.getAccountType();
            pc6.Insert(0, new Report { AccountType_id = 0, gl_nature = "---Select---" });
            ViewBag.Account = pc6;

            ViewBag.Result = await _cost.listOfReport(new Report());
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ViewReport(Report R)//by admin
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name = HttpContext.Session.GetString("Branch");

            List<BranchEntity> pc5 = new List<BranchEntity>();
            pc5 = await _Branch.getbranch();
            pc5.Insert(0, new BranchEntity { branch_id = 0, Branch_Name = "---Select---" });
            ViewBag.Branch = pc5;

            List<Report> pc6 = new List<Report>();
            pc6 = (List<Report>)await _cost.getAccountType();
            pc6.Insert(0, new Report { AccountType_id = 0, gl_nature = "---Select---" });
            ViewBag.Account = pc6;

            ViewBag.Result = await _cost.listOfReport(R);
            return View();
        }
        public async Task<IActionResult> viewPendingCustomerBefore()///pending Customer
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.viewPendingCustomerBefore(CN);
            return View();
        }
        public async Task<IActionResult> viewApprovedCustomerBefore()///approved Customer
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.viewApprovedCustomerBefore(CN);
            return View();
        }
        public async Task<IActionResult> viewPendingDepositeamount()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.viewPendingDepositeamount(CN);
            return View();
        }
        [HttpPost]
        public IActionResult Appprove_Deposite(string id)
        {
            try
            {
                int Result = _cost.Appprove_Deposite(Convert.ToInt32( id));
                return Ok(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public async Task<IActionResult> BindVoucher()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.BindVoucher(HttpContext.Session.GetString("Branch"));
            return View();
        }
        public async Task<IActionResult> ViewCustomermanager()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.listcustmer(CN);
            return View();
        }
        public async Task<IActionResult> ViewUpdateServerDate()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.listcustmer(CN);
            return View();
        }
        public IActionResult UpdateServerDate(string date)
            {
            var Retval = _cost.UpdateServerDate(date,HttpContext.Session.GetString("Branch"));
            return Ok(Retval);

        }


        [HttpPost]
        public async Task<IActionResult> ViewCustomer(CustmerEntity doctor)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            doctor.Branch_Name=HttpContext.Session.GetString("Branch");
            ViewBag.Result = await _cost.listcustmer(doctor);
            return View();
        }

        [HttpPost]
        public IActionResult Deletecustomer(int id)
        {
            try
            {
                int Result = _cost.deletecustmer(id);
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
            var Departments = _cost.custmerselect(Convert.ToInt32(id), HttpContext.Session.GetString("Branch"));
            return Ok(JsonConvert.SerializeObject(Departments));
        }

        [HttpGet]
        public IActionResult GetAccountDetailByAccountNo(string num)
        {
            var Departments = _cost.GetAccountDetailByAccountNo(Convert.ToInt64(num));
            return Ok(JsonConvert.SerializeObject(Departments));
        }

        public IActionResult customerBind(int grouptype_id)
        {

            CustmerEntity ad = new CustmerEntity();

            ad = _cost.custmerselect(grouptype_id, HttpContext.Session.GetString("Branch"));
            ViewBag.Button = "Update";
            //return View(ad);
            return Json(new { data = ad });

        }
       
        public async Task<IActionResult> ViewPendingCustomerDetails()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name = HttpContext.Session.GetString("Branch");

            ViewBag.Result = await _cost.Viewpendinglistcustmer(CN);
            return View();
        }
        
    }
}