using Bank.Domain.Account;
using Bank.Domain.Branch;
using Bank.Irepository.Account;
using Bank.Irepository.Branch;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBank.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IBranchRepository _Branch;
        private readonly IAccountRepository _iacc;
        public AccountController(IAccountRepository iacc, IBranchRepository Branch)
        {
            _iacc = iacc;
            _Branch = Branch;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AdminDashboard()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            List<BranchEntity> pc5 = new List<BranchEntity>();
            pc5 = await _Branch.getbranch();
            pc5.Insert(0, new BranchEntity { branch_id = 0, Branch_Name = "---Select---" });
            ViewBag.Branch = pc5;

            return View();
        }
      
        public IActionResult AddAccounts()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.BranchName = _iacc.GetBranches().Result;
            ViewBag.acctypelist = _iacc.GetAccTypes().Result;
            return View();
        }
        [HttpPost]
        public IActionResult AddAccounts(AccountEntity acc)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.BranchName = _iacc.GetBranches().Result;
            ViewBag.acctypelist = _iacc.GetAccTypes().Result;
            if (acc.Account_id == 0)
            {
                ViewBag.res = _iacc.AddAccount(acc);
            }
            if (ViewBag.res == 2)
            {
                ViewBag.msg = "Account Registered Succesfully !!!";
            }
            else
            {
                ViewBag.msg = "Some Error Found";
            }
            return View();
        }
        public IActionResult ViewAccounts()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.accountlist = _iacc.GetAccounts();
            return View();
        }
        public IActionResult EditAccounts(int id)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.BranchName = _iacc.GetBranches().Result;
            ViewBag.acctypelist = _iacc.GetAccTypes().Result;
            AccountEntity acc = new AccountEntity();
            acc = _iacc.GetAccount(id).Result;
            return View(acc);
        }
        [HttpPost]
        public IActionResult EditAccounts(AccountEntity acc)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.BranchName = _iacc.GetBranches().Result;
            ViewBag.acctypelist = _iacc.GetAccTypes().Result;
            if (acc.Account_id != 0)
            {
                ViewBag.res = _iacc.UpdateAccount(acc);
            }
            if (ViewBag.res == 3)
            {
                ViewBag.msg = "Account Data Updated Successfully !!!";
            }
            else
            {
                ViewBag.msg = "Some Error Found";
            }
            return View();
        }
        public IActionResult DeleteAccounts(int id)
        {
            int res = _iacc.DeleteAccount(id);
            if (res != 0)
            {
                return RedirectToAction("ViewAccounts");
            }
            return View();
        }
    }
}
