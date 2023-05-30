using Bank.Domain.AccountType;
using Bank.Irepository.AccountType;
using Microsoft.AspNetCore.Http;
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
        [HttpGet]
        public IActionResult Addaccount()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Grouplist1 = _iat.GetGIGroupCode().Result;
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
          
        }
        [HttpGet]
        public IActionResult AddaccountSales()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Grouplist1 = _iat.GetGIGroupCode().Result;
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
          
        }
        [HttpPost]
        public IActionResult Addaccount(AccountTypeModel at)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
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
            else
            {
                return RedirectToAction("loginpage", "Login");
            }

           
        }
        public IActionResult ViewAccount()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Grouplist = _iat.getaccount();
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
       
        }
        public IActionResult ViewAccountSales()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Grouplist = _iat.getaccount();
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
          
        }
        public IActionResult EditAccount(int id)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Grouplist1 = _iat.GetGIGroupCode().Result;
                AccountTypeModel at = new AccountTypeModel();
                at = _iat.Getaccount(id).Result;
                return View(at);
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }

          

        }
        public IActionResult EditAccountSales(int id)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Grouplist1 = _iat.GetGIGroupCode().Result;
                AccountTypeModel at = new AccountTypeModel();
                at = _iat.Getaccount(id).Result;
                return View(at);
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
       
        }
        [HttpPost]
        public IActionResult EditAccount(AccountTypeModel at)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                int res = _iat.Updateaccount(at);
                if (res != 0)
                {
                    return RedirectToAction("ViewAccount");
                }
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }
        public IActionResult FillGIGroupCode()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Grouplist1 = _iat.GetGIGroupCode().Result;

                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
         
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
