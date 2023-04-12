using Bank.Irepository.Product;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBank.Web.Controllers
{
    public class productController : Controller
    {
        private readonly IproductRepository _IproductRepository;
        public productController(IproductRepository IproductRepository)
        {
            _IproductRepository = IproductRepository;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult productinsert()
        {
            ViewBag.catagory = _IproductRepository.listcat().Result;
            ViewBag.subcatagory = _IproductRepository.listsubcat().Result;
            return View();
        }
    }
}
