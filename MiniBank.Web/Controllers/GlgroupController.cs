using Bank.Domain.GlGroup;
using Bank.Irepository.GlGroup;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBank.Web.Controllers
{
    public class GlgroupController : Controller
    {
        private readonly IglgroupRepository _rlo;
        public GlgroupController(IglgroupRepository rlo)
        {
            _rlo = rlo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GlgroupinsertSales(int id)
        {
            ViewBag.groupID = _rlo.glgroupbind();
            GlgroupEntity gle = new GlgroupEntity();
            if (id == 0)
            {

                ViewBag.Button = "Save";
            }
            else
            {
                ViewBag.Button = "Update";
                //ViewBag.id = id;
                gle = await _rlo.groupselect(id);
                return View(gle);

            }
            return View();
        }

        [HttpGet]
        public async Task< IActionResult> Glgroupinsert(int id)
        {
            ViewBag.groupID = _rlo.glgroupbind();
            GlgroupEntity gle = new GlgroupEntity();
            if (id == 0)
            {

                ViewBag.Button = "Save";
            }
            else
            {
                ViewBag.Button = "Update";
                //ViewBag.id = id;
                gle =await _rlo.groupselect(id);
                return View(gle);

            }
            return View();
        }



        [HttpPost]
        public IActionResult Glgroupinsert(GlgroupEntity gl)
        {
            ViewBag.groupID = _rlo.glgroupbind();
            if (gl.GlGroup_id == 0)
            {
                ViewBag.data = _rlo.insertgroup(gl);
            }
            else
            {
                ViewBag.data = _rlo.updatgroupl(gl);
            }

            if (ViewBag.data == 2)
            {
                ViewBag.msg = " Registation Succesfully !!!";
            }
            else if (ViewBag.data == 1)
            {

                ViewBag.msg = "already exist";
            }
            else if (ViewBag.data == 3)
            {
                ViewBag.msg = "update successfully";

            }
            else
            {
                ViewBag.msg = "some error found";
            }

            return View();
        }
        [HttpGet]
        public IActionResult GlgroupView()
        {

            GlgroupEntity gle = new GlgroupEntity();
            gle.GlGrouplist = _rlo.listrgroup();
            return View(gle);
        }
        [HttpGet]
        public IActionResult GlgroupViewSales()
        {

            GlgroupEntity gle = new GlgroupEntity();
            gle.GlGrouplist = _rlo.listrgroup();
            return View(gle);
        }

        public JsonResult Checkdetails(int grouptype_id)
        {


            var result = _rlo.Selectone(grouptype_id);
            string jsonresult = JsonConvert.SerializeObject(result);
            return Json(new { data = jsonresult });
        }
    }
}
