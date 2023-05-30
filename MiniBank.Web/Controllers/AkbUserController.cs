using Bank.Domain.User;
using Bank.Irepository.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBank.Web.Controllers
{
    public class AkbUserController : Controller
    {
        private readonly IUserRepository _iusr;

        public AkbUserController(IUserRepository iusr)
        {
            _iusr = iusr;
        }

        [HttpGet]
        public IActionResult Addusers()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {
                ViewBag.RoleName = _iusr.getrollids().Result;
                ViewBag.BranchName = _iusr.getbranchids().Result;
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }
        [HttpPost]
        public IActionResult Addusers(UserEntity usr)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {
                ViewBag.RoleName = _iusr.getrollids().Result;
                ViewBag.BranchName = _iusr.getbranchids().Result;
                if (usr.ID == 0)
                {
                    ViewBag.res = _iusr.AddUser(usr);
                }
                if (ViewBag.res == 2)
                {
                    ViewBag.msg = "User Details Submitted Successfully!!!";
                }

                else if (ViewBag.res == 1)
                {
                    ViewBag.msg = "This Name Already Exist Pls Try Other Name!!!";
                }
                else if (ViewBag.res == 4)
                {
                    ViewBag.msg = "This Email Already Exist Pls Try Other Email!!! ";
                }
                else if (ViewBag.res == 5)
                {
                    ViewBag.msg = "This Mobile Number Already Registerd Plz Try Another!!! ";
                }
                else if (ViewBag.res == 55)
                {
                    ViewBag.msg = "Invalid Agent Id!!! ";
                }


                else
                {
                    ViewBag.msg = "Some Internal Issues in Inserting";
                }
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }

        public IActionResult ViewUsers()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Userlist = _iusr.getusers();
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
          
        }

        public IActionResult EditUsers(int id)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.RoleName = _iusr.getrollids().Result;
                ViewBag.BranchName = _iusr.getbranchids().Result;
                UserEntity gr = new UserEntity();
                gr = _iusr.GetUser(id).Result;
                return View(gr);
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }
        [HttpPost]
        public IActionResult EditUsers(UserEntity usr)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.BranchName = _iusr.getbranchids().Result;
                ViewBag.RoleName = _iusr.getrollids().Result;
                //int res = _iusr.UpdateUser(usr);
                //if (res != 0)
                //{
                //    ViewBag.msg = "data Updated";
                //    return RedirectToAction("ViewUsers");
                //}
                if (usr.ID != 0)
                {
                    ViewBag.res = _iusr.UpdateUser(usr);
                }
                if (ViewBag.res == 3)
                {
                    ViewBag.msg = "data updated successfully";
                }


                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }

        public IActionResult DeleteUsers(int id)
        {
            int res = _iusr.DeleteUser(id);
            if (res != 0)
            {
                return RedirectToAction("ViewUsers");
            }
            return View();
        }


    }
}
