using Bank.Domain.Branch;
using Bank.Irepository.Branch;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBank.Web.Controllers
{
    public class BranchController : Controller
    {
       
        private readonly IBranchRepository _ibr;
        public BranchController(IBranchRepository ibr)
        {
           
            _ibr = ibr;
        }
        public IActionResult Index()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }
        public IActionResult AddBranchs()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }

         
        }
        [HttpPost]
        public IActionResult AddBranchs(BranchEntity br)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                int res = _ibr.AddBranch(br);
                if (res != 0)
                {
                    ViewBag.msg = "Data Added Successfully";
                }
                else
                {
                    ViewBag.msg = "some error found";
                }
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }

         
        }
        public IActionResult EditBranchs(int id)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                BranchEntity br = new BranchEntity();
                br = _ibr.GetBranch(id).Result;
                return View(br);
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }
       
        [HttpPost]
        public IActionResult EditBranchs(BranchEntity br)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                int res = _ibr.UpdateBranch(br);
                if (res != 0)
                {

                    ViewBag.msg = "Data Update Successfully";
                    //return RedirectToAction("ViewBranchs");
                }
                return RedirectToAction("ViewBranchs");
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }

        public IActionResult DeleteBranchs(int id)
        {
            int res = _ibr.DeleteBranch(id);
            if (res != 0)
            {
                return RedirectToAction("ViewBranchs");
            }
            return View();
        }
        public IActionResult ViewBranchs()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Grouplist = _ibr.getbranch();
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
         
        }

    }
}
