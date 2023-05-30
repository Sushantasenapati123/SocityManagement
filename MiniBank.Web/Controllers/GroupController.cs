using Bank.Domain.Group;
using Bank.Irepository.Group;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBank.Web.Controllers
{
    public class GroupController : Controller
    {
        private readonly IGroupRepository _igr;
        public GroupController(IGroupRepository igr)
        {
            _igr = igr;
        }
        [HttpGet]
        public IActionResult AddGroups()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Role = HttpContext.Session.GetString("Role");
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }
        [HttpGet]
        public IActionResult AddGroupsSales()
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
        public IActionResult AddGroups(group_entity gr)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Role = HttpContext.Session.GetString("Role");
                if (gr.Grouptype_id == 0)
                {
                    ViewBag.res = _igr.AddGroup(gr);
                }
                if (ViewBag.res == 2)
                {
                    ViewBag.msg = "Group Save Succesfully !!!";
                }
                else if (ViewBag.res == 1)
                {
                    ViewBag.msg = "Group Name already exist";
                }

                else
                {
                    ViewBag.msg = "Some Error Found";
                }
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }
        [HttpGet]
        public IActionResult ViewGroups()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Role = HttpContext.Session.GetString("Role");
                ViewBag.Grouplist = _igr.getgroups();
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }
        [HttpGet]
        public IActionResult ViewGroupsSales()
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Grouplist = _igr.getgroups();
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }

           
        }
        [HttpGet]
        public IActionResult EditGroups(int id)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Role = HttpContext.Session.GetString("Role");
                group_entity gr = new group_entity();
                gr = _igr.GetGroup(id).Result;
                return View(gr);
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }

          
        }
        [HttpGet]
        public IActionResult EditGroupsSales(int id)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                group_entity gr = new group_entity();
                gr = _igr.GetGroup(id).Result;
                return View(gr);
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
           
        }

        [HttpPost]
        public IActionResult EditGroups(group_entity gr)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                ViewBag.Role = HttpContext.Session.GetString("Role");
                if (gr.Grouptype_id != 0)
                {
                    ViewBag.res = _igr.UpdateGroup(gr);
                }
                if (ViewBag.res == 3)
                {
                    ViewBag.msg = "Updation Save Succesfully !!!";
                }
                else
                {
                    ViewBag.msg = "Some Error Found in Data Updation";
                }
                return View();
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
            
        }

        [HttpGet]
        public IActionResult DeleteGroups(int id)
        {
            int res = _igr.DeleteGroup(id);
            if (res != 0)
            {
                return RedirectToAction("ViewGroups", "Group");
            }
            return View();
        }
    }
}