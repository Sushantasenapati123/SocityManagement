using Bank.Domain.User;
using Bank.Irepository.User;
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
            ViewBag.RoleName = _iusr.getrollids().Result;
            ViewBag.BranchName = _iusr.getbranchids().Result;
            return View();
        }
        [HttpPost]
        public IActionResult Addusers(UserEntity usr)
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


            else
            {
                ViewBag.msg = "Some Internal Issues in Inserting";
            }
            return View();
        }

        public IActionResult ViewUsers()
        {
            ViewBag.Userlist = _iusr.getusers();
            return View();
        }

        public IActionResult EditUsers(int id)
        {
            ViewBag.RoleName = _iusr.getrollids().Result;
            ViewBag.BranchName = _iusr.getbranchids().Result;
            UserEntity gr = new UserEntity();
            gr = _iusr.GetUser(id).Result;
            return View(gr);
        }
        [HttpPost]
        public IActionResult EditUsers(UserEntity usr)
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
