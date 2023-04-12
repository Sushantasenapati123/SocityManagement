using Bank.Domain.Branch;
using Bank.Irepository.Branch;
using Microsoft.AspNetCore.Hosting;
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
            return View();
        }
        public IActionResult AddBranchs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBranchs(BranchEntity br)
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
        public IActionResult EditBranchs(int id)
        {
            BranchEntity br = new BranchEntity();
            br = _ibr.GetBranch(id).Result;
            return View(br);
        }
       
        [HttpPost]
        public IActionResult EditBranchs(BranchEntity br)
        {
            int res = _ibr.UpdateBranch(br);
            if (res != 0)
            {
                
                ViewBag.msg = "Data Update Successfully";
                //return RedirectToAction("ViewBranchs");
            }
            return RedirectToAction("ViewBranchs");
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
            ViewBag.Grouplist = _ibr.getbranch();
            return View();
        }

    }
}
