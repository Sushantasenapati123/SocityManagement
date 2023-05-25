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
            ViewBag.Role = HttpContext.Session.GetString("Role");
            CustmerEntity CN = new CustmerEntity();
            CN.Branch_Name = HttpContext.Session.GetString("Branch");
            ViewBag.Result = await _cost.ViewSummaryOfDatFile(CN);
            return View();
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
        public IActionResult ApprovedCustomerAccount(CustmerEntity en)
        {  string ipaddress= GetLocalIPAddress();
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
        [HttpPost]
        public IActionResult upload(IFormFile file)
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
                    {   DateTime colllectdat = DateTime.Now;
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
                                datFilecolllectdate  = Convert.ToDateTime(s[3]);
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
    }
}
