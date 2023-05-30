using Bank.Domain.Branch;
using Bank.Domain.EmployeeRegistration;
using Bank.Irepository.Branch;
using Bank.Irepository.Employee;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBank.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IEmployee _Emp;
        private readonly IBranchRepository _Branch;
        public EmployeeController(IEmployee Emp, IWebHostEnvironment environment,IBranchRepository Branch)
        {
            _Emp = Emp;
            _environment = environment;
            _Branch = Branch;
        }
        [HttpPost]
        public IActionResult UploadImage(IFormFile MyUploader)
        {
            if (MyUploader != null)
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

        public async Task<IActionResult> AddEmployee()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                List<BranchEntity> pc5 = new List<BranchEntity>();
                pc5 = await _Branch.getbranch();
                pc5.Insert(0, new BranchEntity { branch_id = 0, Branch_Name = "---Select---" });
                ViewBag.Branch = pc5;

                List<EmployeeEntity> pc4 = new List<EmployeeEntity>();
                pc4 = await _Emp.bindDesigNation();
                pc4.Insert(0, new EmployeeEntity { DesgId = 0, DesgName = "---Select---" });
                ViewBag.Designation = pc4;

                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }
        [HttpGet]
        public IActionResult GetByIdEmployee(int id)
        {
            var Departments = _Emp.selectEmployee(Convert.ToInt32(id));
            return Ok(JsonConvert.SerializeObject(Departments));
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeEntity custe)
        {

              var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                string[] files = custe.Photo.Split('\\');
                custe.Photo = "prodimage/" + files[files.Length - 1];

                int retMsg = _Emp.insertEmployee(custe);

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
            else
            {
                return RedirectToAction("loginpage", "Login");
            }

         
        }
        public async Task<IActionResult> ViewEmployee()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                List<EmployeeEntity> pc4 = new List<EmployeeEntity>();
                pc4 = await _Emp.bindDesigNation();
                pc4.Insert(0, new EmployeeEntity { DesgId = 0, DesgName = "---Select---" });
                ViewBag.Designation = pc4;

                ViewBag.Result = await _Emp.listcustmer(new EmployeeEntity());
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
          
        }
        [HttpPost]
        public async Task<IActionResult> ViewEmployee(EmployeeEntity e)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                List<EmployeeEntity> pc4 = new List<EmployeeEntity>();
                pc4 = await _Emp.bindDesigNation();
                pc4.Insert(0, new EmployeeEntity { DesgId = 0, DesgName = "---Select---" });
                ViewBag.Designation = pc4;

                ViewBag.Result = await _Emp.listcustmer(e);
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }
        [HttpPost]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                int Result = _Emp.deleteEmployee(id);
                return Ok(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
