using Bank.Domain.Role;
using Bank.Irepository.ServerData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBank.Web.Controllers
{
    public class Role_MasterController : Controller
    {
        private readonly IRoleRegistation _rlo;
        public Role_MasterController(IRoleRegistation rlo)
        {
            _rlo = rlo;
        }

        #region role operation
        [HttpGet]
        public IActionResult Roleinsert(int ID, string Rolename)
        {
            

            if (ID == 0)
            {
                ViewBag.msg = null;

                ViewBag.Button = "Register";
                return View();
            }
            else
            {
                RoleEntity ad = new RoleEntity();
                ViewBag.Rolename = Rolename;
                ViewBag.ID = ID;
                ad = _rlo.Rolebind(ID);
                if (ad.ALLOW_GL == "Y")
                {
                    ad.ALLOW_GL = "true";
                }
                else
                {
                    ad.ALLOW_GL = "false";
                }
                if (ad.ALLOW_AC == "Y")
                {
                    ad.ALLOW_AC = "true";
                }
                else
                {
                    ad.ALLOW_AC = "false";
                }
                if (ad.ALLOW_BNK_INFO == "Y")
                {
                    ad.ALLOW_BNK_INFO = "true";
                }
                else
                {
                    ad.ALLOW_BNK_INFO = "false";
                }

                if (ad.ALLOW_CC == "Y")
                {
                    ad.ALLOW_CC = "true";
                }
                else
                {
                    ad.ALLOW_CC = "false";
                }
                if (ad.ALLOW_CR_USR == "Y")
                {
                    ad.ALLOW_CR_USR = "true";
                }
                else
                {
                    ad.ALLOW_CR_USR = "false";
                }
                if (ad.ALLOW_DEPO_AP == "Y")
                {
                    ad.ALLOW_DEPO_AP = "true";
                }
                else
                {
                    ad.ALLOW_DEPO_AP = "false";
                }
                if (ad.ALLOW_DISBURSE == "Y")
                {
                    ad.ALLOW_DISBURSE = "true";
                }
                else
                {
                    ad.ALLOW_DISBURSE = "false";
                }
                if (ad.ALLOW_EC == "Y")
                {
                    ad.ALLOW_EC = "true";
                }
                else
                {
                    ad.ALLOW_EC = "false";
                }
                if (ad.ALLOW_INT_PARA == "Y")
                {
                    ad.ALLOW_INT_PARA = "true";
                }
                else
                {
                    ad.ALLOW_INT_PARA = "false";
                }
                if (ad.ALLOW_LN_AP == "Y")
                {
                    ad.ALLOW_LN_AP = "true";
                }
                else
                {
                    ad.ALLOW_LN_AP = "false";
                }
                if (ad.ALLOW_LN_REPAY == "Y")
                {
                    ad.ALLOW_LN_REPAY = "true";
                }
                else
                {
                    ad.ALLOW_LN_REPAY = "false";
                }
                if (ad.ALLOW_NEW_DEPO == "Y")
                {
                    ad.ALLOW_NEW_DEPO = "true";
                }
                else
                {
                    ad.ALLOW_NEW_DEPO = "false";
                }
                if (ad.ALLOW_NEW_LOAN == "Y")
                {
                    ad.ALLOW_NEW_LOAN = "true";
                }
                else
                {
                    ad.ALLOW_NEW_LOAN = "false";
                }
                if (ad.ALLOW_RENEW_EXP == "Y")
                {
                    ad.ALLOW_RENEW_EXP = "true";
                }
                else
                {
                    ad.ALLOW_RENEW_EXP = "false";
                }
                if (ad.ALLOW_SPCL == "Y")
                {
                    ad.ALLOW_SPCL = "true";
                }
                else
                {
                    ad.ALLOW_SPCL = "false";
                }
                if (ad.ALLOW_VCH == "Y")
                {
                    ad.ALLOW_VCH = "true";
                }
                else
                {
                    ad.ALLOW_VCH = "false";
                }
                if (ad.ALLOW_VCH_AP == "Y")
                {
                    ad.ALLOW_VCH_AP = "true";
                }
                else
                {
                    ad.ALLOW_VCH_AP = "false";
                }
                if (ad.ALLOW_VCH_EDIT == "Y")
                {
                    ad.ALLOW_VCH_EDIT = "true";
                }
                else
                {
                    ad.ALLOW_VCH_EDIT = "false";
                }
                ViewBag.Button = "Update";
                return View(ad);

            }

        }
        [HttpPost]
        public IActionResult Roleinsert(RoleEntity rle)
        {
            if (rle.ROLE_ID == 0)
            {
                ViewBag.res = _rlo.insertrole(rle);
            }
            else
            {
                ViewBag.data = _rlo.updaterol(rle);
            }

            if (ViewBag.res == 2)
            {
                ViewBag.msg = "Role Save Succesfully !!!";
            }
            else if (ViewBag.res == 1)
            {

                ViewBag.msg = "Role Name already exist";
            }
            else if (ViewBag.data == 3)
            {
                ViewBag.msg = "Role update successfully !";

            }
            else
            {
                ViewBag.msg = "some error found";
            }

            return View();
        }
        [HttpGet]
        public IActionResult roleDetailsView()
        {

            ViewBag.RoleName = _rlo.listrole().Result;
            return View();


        }
        [HttpPost]
        public JsonResult Checkdetails(int INTLEVELID)
        {
            RoleEntity ad = new RoleEntity();
            ad = _rlo.Roleselect(INTLEVELID);
            return Json(new { data = ad });


        }


        //[HttpGet]
        //public IActionResult RoleView(int id, string Rolename)
        //{
        //    RoleEntity ad = new RoleEntity();
        //   // DapperContext obj = new DapperContext();
        //    ViewBag.msg = null;
        //    if (id != 0)
        //    {
        //        ViewBag.Rolename = Rolename;
        //        ViewBag.ID = id;
        //       // ad = obj.Rolebind(id);

        //    }
        //    return View(ad);
        //}


        //        [HttpPost]
        //        public IActionResult RoleView([FromForm] RoleEntity Rle)
        //        {
        //            DapperContext obj = new DapperContext();

        //            RoleEntity ad = new RoleEntity();
        //            if (Rle.ROLE_ID == 0)
        //            {
        //                ViewBag.data = obj.RoleInsert(Rle);
        //            }
        //            else
        //            {
        //                ViewBag.data = obj.Roleupdate(Rle);
        //            }
        //            if (ViewBag.data == "2")
        //            {
        //                ViewBag.msg = "Role Save Succesfully !!!";
        //            }
        //            else if (ViewBag.data == "1")
        //            {
        //                ViewBag.msg = "Role already exists!";

        //            }
        //            else if (ViewBag.data == "3")
        //            {
        //                ViewBag.msg = "Role update successfully !";

        //            }
        //            else
        //            {
        //                ViewBag.msg = "Something went wrong !!!";

        //            }

        //            return View();



        //        }
        //        [HttpGet]
        //        public IActionResult rolemanagementView()
        //        {

        //            RoleEntity Rl = new RoleEntity();
        //            DapperContext obj = new DapperContext();
        //            ViewBag.RoleName = obj.Show_roledata();

        //            return View(Rl);




        //        }
        //        //[HttpPost]
        //        public IActionResult Checkdetails(int INTLEVELID)
        //        {


        //            DapperContext obj = new DapperContext();
        //            RoleEntity ad = new RoleEntity();
        //            ViewBag.selectone = obj.Roleselect(INTLEVELID);
        //            //ad= obj.Roleselect(INTLEVELID);
        //            return Ok(JsonConvert.SerializeObject(ViewBag.selectone));
        //            //return View(ad);

        //        }
        #endregion
        //        #region User Registation
        //        [HttpGet]
        //        public IActionResult Registion()
        //        {
        //            RoleEntity Rl = new RoleEntity();
        //            DapperContext obj = new DapperContext();
        //            ViewBag.RoleName = obj.Show_roledata();
        //            ViewBag.BranchName = obj.BrancDropdown();
        //            return View();

        //        }
        //        [HttpPost]
        //        public IActionResult Registion(UserRegistation_entity ure)
        //        {
        //            RoleEntity Rl = new RoleEntity();
        //            // BranchEntity ad = new BranchEntity();
        //            DapperContext obj = new DapperContext();
        //            ViewBag.RoleName = obj.Show_roledata();
        //            ViewBag.BranchName = obj.BrancDropdown();
        //            ViewBag.result = obj.UserInsert(ure);
        //            if (ViewBag.result == "1")
        //            {
        //                ViewBag.msg = "Registation Succesfully !!!";
        //            }

        //            return View();
        //  }
        //#endregion
    } }