﻿using Bank.Domain.Login;
using Bank.Irepository.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBank.Web.Controllers
{
   
        public class LoginController : Controller
        {
            private readonly IloginRepository _IloginRepository;
            public LoginController(IloginRepository iloginRepository)
            {
                _IloginRepository = iloginRepository;
            }
            [HttpGet]
            public IActionResult login()
            {
             
                return View();
            }
            public IActionResult loginpage()
            {
                return View();
            }

            [HttpPost]
            public IActionResult loginpage(LoginEntity obj)
            {
                var result = _IloginRepository.GetDetails(obj);
                if (result.Count > 0)
                {
                    if(result[0].ROLE_NAME=="Sales")
                    {
                        HttpContext.Session.SetInt32("USERID", result[0].Id);
                    HttpContext.Session.SetString("Role", result[0].ROLE_NAME);
                    HttpContext.Session.SetString("Branch", result[0].Branch_Name);

                    return RedirectToAction("AddaccountSales", "AccountType");
                    }
                    else                     {
                         HttpContext.Session.SetInt32("USERID", result[0].Id);
                        if(result[0].Branch_Name==null && result[0].ROLE_NAME==null)
                        {
                            result[0].ROLE_NAME = "Super Admin";
                          
                        HttpContext.Session.SetString("Role", result[0].ROLE_NAME);
                        HttpContext.Session.SetString("Branch", result[0].adminbranchName);
                        HttpContext.Session.SetString("Userid", result[0].USER_ID);
                        return RedirectToAction("AdminDashboard", "Account");
                    }
                         HttpContext.Session.SetString("Role", result[0].ROLE_NAME);
                         HttpContext.Session.SetString("Branch", result[0].Branch_Name);
                         HttpContext.Session.SetString("Userid", result[0].USER_ID);

                    return RedirectToAction("index", "AccountOpening");
                    }
                  
                   
                }
                else
                {
                    ViewBag.msg = "User Id And Password !!!!!";
                    return View();
                }

            }
        }
    }
