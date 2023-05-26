using Bank.Domain.Branch;
using Bank.Domain.Customer;
using Bank.Irepository.AccountingOpening;
using Bank.Irepository.Branch;
using Bank.Irepository.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Bank.Domain.Customer.CustmerEntity;

namespace MiniBank.Web.Controllers
{
    public class TestController : Controller
    {
        private readonly IAccountopeningRepository _IAccountopeningRepository;
        private readonly ICustmerRepository _cost;
        private readonly IBranchRepository _Branch;
        public TestController(IAccountopeningRepository IAR, ICustmerRepository cost, IBranchRepository Branch)
        {
            _IAccountopeningRepository = IAR;
            _cost = cost;
            _Branch = Branch;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ViewBranchWiseCustomerTest()
        {
            List<BranchEntity> pc5 = new List<BranchEntity>();
            pc5 = await _Branch.getbranch();
            pc5.Insert(0, new BranchEntity { branch_id = 0, Branch_Name = "---Select---" });
            ViewBag.Branch = pc5;

            List<Report> pc6 = new List<Report>();
            pc6 = (List<Report>)await _cost.getAccountType();
            // pc6.Insert(0, new Report { AccountType_id = 0, gl_nature = "---Select---" });
            ViewBag.Account = pc6;

            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Branchn = HttpContext.Session.GetString("Branch");
            ViewBag.Result = await _cost.listcustmerBranchWise(new CustmerEntity());
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> ViewBranchWiseCustomerTest(int  id)
        {
            List<BranchEntity> pc5 = new List<BranchEntity>();
            pc5 = await _Branch.getbranch();
            pc5.Insert(0, new BranchEntity { branch_id = 0, Branch_Name = "Select" });
            ViewBag.Branch = pc5;

            List<Report> pc6 = new List<Report>();
            pc6 = (List<Report>)await _cost.getAccountType();
            //pc6.Insert(0, new Report { AccountType_id = 0, gl_nature = "---Select---" });
            ViewBag.Account = pc6;


            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Branchn = "Khordha";// HttpContext.Session.GetString("Branch");
            ViewData["ch"] = "Khordha";
            ViewBag.Result = await _cost.listcustmerBranchWise(new CustmerEntity());

            CustmerEntity cs = new CustmerEntity();
            cs.branch_id = id;
            List<CustmerEntity> EmpList = _cost.listcustmerBranchWise(cs).Result.ToList();
            // var list = EmpList;
            return Json(new { data = EmpList });
        }
      
    }
}
