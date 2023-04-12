using Bank.Domain.ServerData;
using Bank.Irepository.Role;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBank.Web.Controllers
{
    public class ServerDateController : Controller
    {
        private readonly IServerDateRepository _isdr;
        public ServerDateController(IServerDateRepository isdr)
        {
            _isdr = isdr;
        }

        [HttpGet]
        public IActionResult AddServerDate()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.BranchName = _isdr.listBranch().Result;
            return View();
            //return RedirectToAction("AddServerDate", "ServerDate");
        }
        [HttpPost]
        public IActionResult AddServerDate(ServerDateEntity svrDt)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.BranchName = _isdr.listBranch().Result;
            //int res = _isdr.AddServerDate(svrDt);
            if (svrDt.Server_id == 0)
            {
                ViewBag.res = _isdr.AddServerDate(svrDt);
            }
            if (ViewBag.res == 1)
            {
                ViewBag.msg = "Server Date Added Successfully.";
            }
            //if (res != 0)
            //{
            //    ViewBag.msg = "Server Date Added Successfully.";
            //}
            else
            {
                ViewBag.msg = "Some Error Occured in Insertion";
            }
            return View();
            //return RedirectToAction("AddServerDate", "ServerDate");
        }
        [HttpGet]
        public IActionResult ViewServerDate()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Datelist = _isdr.GetServerDate();
            return View();
        }
        [HttpGet]
        public IActionResult EditServerDate(int id)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.BranchName = _isdr.listBranch().Result;
            ServerDateEntity sr = new ServerDateEntity();
            sr = _isdr.GetDate(id).Result;
            return View(sr);
        }
        [HttpPost]
        public IActionResult EditServerDate(ServerDateEntity sd)
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.BranchName = _isdr.listBranch().Result;
            if (sd.Server_id != 0)
            {
                ViewBag.res = _isdr.UpdateServerDate(sd);
            }
            if (ViewBag.res == 2)
            {
                ViewBag.msg = "Server Date Updated Successfully.";
            }
            else
            {
                ViewBag.msg = "Some error in updation.";
            }
            //int res = _isdr.UpdateServerDate(sd);
            //if (res != 0)
            //{
            //    return RedirectToAction("ViewServerDate");
            //}
            return View();
        }
        [HttpGet]
        public IActionResult DeleteServerDate(int id)
        {
            int res = _isdr.DeleteServerDate(id);
            if (res != 0)
            {
                ViewBag.msg = "Data Deleted Successfully.";
                return RedirectToAction("ViewServerDate");
            }
            else
            {
                ViewBag.msg = "Error In Delete.";
            }
            return View();
        }

        [HttpGet]
        public IActionResult GetByBranchId(int id)
        {
            ServerDateEntity srd = new ServerDateEntity();
            srd = _isdr.GetByBranch(id).Result;
            return Json(srd);

            //return RedirectToAction("AddServerDate", "ServerDate",srd);
            //List<ServerDateEntity> lstBranch = new List<ServerDateEntity>();
            //lstBranch = _isdr.listBranch().Result.ToList();
            //return Json(new { Message = lstBranch });
        }
    }
}
