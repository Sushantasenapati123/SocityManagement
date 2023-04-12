using Bank.Domain.AccountType;
using Bank.Irepository.AccountType;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBank.Web.Controllers
{
    public class AccountTypeController : Controller
    {
        private readonly IAccountTypeRepository _iat;
        public AccountTypeController(IAccountTypeRepository iat)
        {
            _iat = iat;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Addaccount()
        {
            ViewBag.Grouplist1 = _iat.GetGIGroupCode().Result;
            return View();
        }
        [HttpGet]
        public IActionResult AddaccountSales()
        {
            ViewBag.Grouplist1 = _iat.GetGIGroupCode().Result;
            return View();
        }
        [HttpPost]
        public IActionResult Addaccount(AccountTypeModel at)
        {
            if (at.AccountType_id == 0)
            {
                ViewBag.Grouplist1 = _iat.GetGIGroupCode().Result;
                var res = _iat.accountAdd(at);
                if (res != 0)
                {
                    ViewBag.msg = "data added";
                }
                else
                {
                    ViewBag.msg = "some error found";
                }
               
            }
            else
            {
                int res = _iat.Updateaccount(at);

                if (res != 0)
                {
                    ViewBag.msg = "data updated";
                }
                else
                {
                    ViewBag.msg = "some error found";
                }
            }
            return View();
        }
        public IActionResult ViewAccount()
        {
            ViewBag.Grouplist = _iat.getaccount();
            return View();
        }
        public IActionResult ViewAccountSales()
        {
            ViewBag.Grouplist = _iat.getaccount();
            return View();
        }
        public IActionResult EditAccount(int id)
        {
            ViewBag.Grouplist1 = _iat.GetGIGroupCode().Result;
            AccountTypeModel at = new AccountTypeModel();
            at = _iat.Getaccount(id).Result;
            return View(at);

        }
        public IActionResult EditAccountSales(int id)
        {
            ViewBag.Grouplist1 = _iat.GetGIGroupCode().Result;
            AccountTypeModel at = new AccountTypeModel();
            at = _iat.Getaccount(id).Result;
            return View(at);
        }
        [HttpPost]
        public IActionResult EditAccount(AccountTypeModel at)
        {
            int res = _iat.Updateaccount(at);
            if (res != 0)
            {
                return RedirectToAction("ViewAccount");
            }
            return View();
        }
        public IActionResult FillGIGroupCode()
        {
            ViewBag.Grouplist1 = _iat.GetGIGroupCode().Result;

            return View();
        }

        public IActionResult deleteaccount(int id)
        {
            int res = _iat.Deleteaccount(id);
            if (res != 0)
            {
                return RedirectToAction("ViewAccount");
            }
            return View();
        }
        public IActionResult BindGIcode(string GlGroup_code)
        {
            try
            {
                var result = _iat.getgicode(GlGroup_code);
                // string jsonresult = JsonConvert.SerializeObject(result);
                return Json(new { data = result });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
