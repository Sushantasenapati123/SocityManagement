using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Bank.Irepository.Customer;
using Bank.Domain.Customer;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Linq;

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
        public async Task<IActionResult> ViewSummaryOfDatFile()
        {
            // SaveTemplateConfig();
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {
                ViewBag.Role = HttpContext.Session.GetString("Role");
                CustmerEntity CN = new CustmerEntity();
                CN.Branch_Name = HttpContext.Session.GetString("Branch");
                ViewBag.Result = await _cost.ViewSummaryOfDatFile(CN);
                return View();
               
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }

          
        }

        public ActionResult pigme()
        {
            string st = @"" + BaseUrl + "VNC-Viewer-7.0.1-Windows.exe";
            Process process = new Process();
            process.StartInfo.FileName = st;
            process.Start();
            return RedirectToAction("fileUpload");
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        [HttpPost]
        public IActionResult SaveTemplateConfig()
        {
            try
            {
                //int UserId = 0;
                //UserId = (int)HttpContext.Session.GetInt32("_UserId");
                //var data = HttpContext.Request.Form["TemplateConfig"];//await _cost.ViewUploadDatfileRecord(CN);
                List< CustmerEntity > listvalue = _cost.ViewUploadDatfileRecord(new CustmerEntity()).Result.ToList();
                //var ResultDtls = JsonConvert.DeserializeObject<List<CustmerEntity>>(listvalue.ToString());
                                                                             
                CustmerEntity model = new CustmerEntity();
                var xEle = new XDocument();
                var dec = new XDeclaration("1.0", "UTF-8", "yes");
                xEle.Declaration = dec;
                xEle.Add(new XElement("person", from emp in listvalue
                                                select new XElement("row",
                                                new XElement("customername", emp.customername),
                                                new XElement("Amount", emp.Amount),
                                                new XElement("Account_Number", emp.Account_Number),
                                                new XElement("Account_Number", emp.Account_Number),
                                                new XElement("Agent_Code", emp.Agent_Code)
                                                )));

                string result = string.Empty;
                model.TemplateConfigXml = xEle;
                int x = _cost.Appprove_DailyDepositeTextfile(model);
                return View();
                //try
                //{
                //    int count = _dashboard.CheckExcelTemplateMapping(Schemeid, SubSchemeid).Result;
                //    if (count == 0)
                //    {
                //        string Result = _dashboard.InsertTemplateConfig(model);
                //        ViewBag.Schemeview = _dashboard.SchemeViewLevels().Result;
                //        return Json(Result);
                //    }
                //    else
                //    {
                //        ViewBag.Result = 2;
                //        ViewBag.Schemeview = _dashboard.SchemeViewLevels().Result;
                //        return View();
                //    }
                //}
                //catch (Exception ex)
                //{
                //    result = ex.Message;
                //    return Json(ex.Message);
                //}

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public IActionResult ApprovedCustomerAccount(CustmerEntity en)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                string ipaddress = GetLocalIPAddress();
                CustmerEntity ce = new CustmerEntity();
                foreach (var DD in en.ApproveDailyDeposit)
                {
                    ce.NewAccountNo = DD.NewAccountNo;
                    ce.Amount = DD.Amount;
                    ce.customername = HttpContext.Session.GetString("Userid");
                    ce.Collection_date = DD.Collection_date;
                    ce.Agent_Code = DD.Agent_Code;
                    ce.IP = ipaddress;
                    ce.currentym = DateTime.Now.ToString("h:mm:ss tt");
                    ce.BranchName = HttpContext.Session.GetString("Branch");
                    int x = _cost.Appprove_DailyDepositeTextfile(ce);
                }

                return RedirectToAction("fileUpload");
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
          
        }
        [HttpPost]
        public IActionResult upload(IFormFile file)
        {
            var UserId = HttpContext.Session.GetString("Userid");
            if (!string.IsNullOrEmpty(UserId.ToString()))
            {

                try
                {
                    //if (file != null)
                    //{
                    //if (file.FileName.ToString().Split(".")[1] != "dat")
                    //{
                    //    ViewData["msg"] = "Please select DAT File";
                    //    return View("fileUpload");
                    //}
                    string ln;
                    using (StreamReader ss = new StreamReader(BaseUrl + "pig_2_pc.dat"))
                    {
                        DateTime colllectdat = DateTime.Now;
                        DateTime datFilecolllectdate = DateTime.Now; ;
                        int counter = 0;
                        int no = -6;
                        while ((ln = ss.ReadLine()) != null)
                        {

                            string[] s = ln.Split(","); ;
                            if (ln != "")
                            {
                                if (counter == 0)
                                {
                                    s = ln.Split(",");
                                    colllectdat = Convert.ToDateTime(s[3]);
                                    datFilecolllectdate = Convert.ToDateTime(s[3]);
                                    counter++;
                                }
                                else
                                {
                                    int k = 1;
                                    while (no < 0)
                                    {
                                        string[] s1 = ln.Split(",");
                                        CustmerEntity ce = new CustmerEntity();
                                        ce.NewAccountNo = Convert.ToInt64(s1[0]);
                                        ce.Amount = Convert.ToInt64(s1[k]);
                                        ce.BranchName = s1[7];
                                        ce.Agent_Code = s1[8];
                                        ce.coltdate = colllectdat.AddDays(no);
                                        ce.DAT_File_CollecttionDate = datFilecolllectdate;
                                        ce.IP = GetLocalIPAddress();
                                        ce.currentym = DateTime.Now.ToString("h:mm:ss tt");
                                        ce.customername = HttpContext.Session.GetString("Userid");
                                        int x = _cost.InsertingDailyDepositeListIntoTempTable(ce);//100034990016,400,Kalpana,1000302002,2023-05-10
                                        no++;
                                        k++;
                                    }
                                    no = -6;
                                }

                            }
                            else
                                break;

                        }
                        ss.Close();

                    }
                    ViewBag.msg = "Successfully Uploaded";
                    return View("fileUpload");
                    //}
                    //else
                    //{
                    //    ViewData["msg"] = "Please select a file";
                    //    return View("fileUpload");
                    //    //return RedirectToAction("fileUpload", "fileUpload");
                    //}
                }
                catch (Exception Ex)
                {
                    ViewBag.msg = Ex.Message;
                    return View("fileUpload");
                    throw Ex;

                }
            }
            else
            {
                return RedirectToAction("loginpage", "Login");
            }
          
        }
    }
}
