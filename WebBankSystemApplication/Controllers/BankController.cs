using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBankSystemApplication.Models;

namespace WebBankSystemApplication.Controllers
{
    public class BankController : Controller
    {

        // GET: Bank
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bank
        public ActionResult BankDetails()
        {

            var bankDetails = new Bank();

            var bankDetailsFilled = new Bank("Arab Bank", 1, "Ramallah", 1223);
            //var details = bankDetailsFilled.BankName + bankDetailsFilled.BankId + bankDetailsFilled.Address + bankDetailsFilled.BankId;
            //ViewBag.bankDetails = details;
            ViewBag.BankDetails = bankDetailsFilled;
            return View();
        }


    }
}