using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Bank.Irepository.Customer;
using Bank.Domain.Customer;

namespace MiniBank.Web.Controllers
{
    public class fileUploadController : Controller
    {
        private readonly ICustmerRepository _cost;
        private readonly string BaseUrl;
        private readonly IConfiguration _iconfiguration;
        public fileUploadController(IConfiguration iconfiguration, ICustmerRepository cost)
        {
            _iconfiguration = iconfiguration;
            _cost = cost;
            BaseUrl = _iconfiguration.GetSection("BaseUrl").GetSection("BaseUrlpath").Value;
        }
        public ActionResult fileUpload()
        {
            return View();
        }


        [HttpPost]
        public IActionResult upload(IFormFile file)
        {
            try
            {
                
                    if (file != null)
                {
                    if (file.FileName.ToString().Split(".")[1] != "txt")
                    {
                        ViewData["msg"] = "Please select Text File";
                        return View("fileUpload");
                    }


                    string ln;
                    // Read file using StreamReader. Reads file line by line
                    using (StreamReader ss = new StreamReader(BaseUrl + file.FileName))
                    {
                        int counter = 0;
                        while ((ln = ss.ReadLine()) != null)
                        {
                            if (ln != "")
                            {
                                string[] s = ln.Split(",");
                                CustmerEntity ce = new CustmerEntity();
                                ce.NewAccountNo = Convert.ToInt64(s[0]);
                                ce.Amount = Convert.ToInt64(s[1]);
                                ce.BranchName = s[2];
                                ce.Agent_Code = s[3];
                                ce.Collection_date = s[4];
                                _cost.Appprove_DailyDepositeTextfile(ce);
                                counter++;
                            }
                            else
                                break;

                        }
                        ss.Close();

                    }
                    ViewBag.msg = "Successfully Uploaded";
                    return View("fileUpload");
                }
                else
                {
                    ViewData["msg"] = "Please select a file";
                    return View("fileUpload");
                    //return RedirectToAction("fileUpload", "fileUpload");
                }
            }
            catch (Exception Ex)
            {
                ViewBag.msg = Ex.Message;
                return View("fileUpload");
                throw Ex;

            }
        }

    }
}
