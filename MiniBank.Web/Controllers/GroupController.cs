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
            ViewBag.Role = HttpContext.Session.GetString("Role");
            return View();
        }
        [HttpGet]
        public IActionResult AddGroupsSales()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGroups(group_entity gr)
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
        [HttpGet]
        public IActionResult ViewGroups()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Grouplist = _igr.getgroups();
            return View();
        }
        [HttpGet]
        public IActionResult ViewGroupsSales()
        {
            ViewBag.Grouplist = _igr.getgroups();
            return View();
        }
        [HttpGet]
        public IActionResult EditGroups(int id)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            group_entity gr = new group_entity();
            gr = _igr.GetGroup(id).Result;
            return View(gr);
        }
        [HttpGet]
        public IActionResult EditGroupsSales(int id)
        {
            group_entity gr = new group_entity();
            gr = _igr.GetGroup(id).Result;
            return View(gr);
        }

        [HttpPost]
        public IActionResult EditGroups(group_entity gr)
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