using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBankSystemApplication.Models;


namespace WebBankSystemApplication.Controllers
{
   
    public class AccountController : Controller
    {  List<User> users = new List<User>();
 
   
        public ActionResult Index()
        {
            return View("WelcomeView");
        }

        [HttpPost]
        public ActionResult GetAllOpenedAccount(User model)
        {
                var users = Session["users"] != null ? (List<User>)Session["users"] : new List<User>();
                var user = new User();
                user.Name = @model.Name;
                user.Email = @model.Email;
                user.gender = @model.gender;
                user.Balance = @model.Balance;
                Guid ID = Guid.NewGuid();
                user.account.AccountId = ID;
                @model.account.AccountId = user.account.AccountId;
                users.Add(user);
                Session["users"] = users;
     
            return View(model);
        }

        public ActionResult FillAccountInfo()
        { 
            return View();
        }
        public ActionResult FillIdToCloseAccount()
        {
            return View();
        }
        public ActionResult CloseMessage()
        { 
           
            return View();
         
        }
        
        public ActionResult CloseAccount(FormCollection closeForm)
        {
            var accountIdFromUi = closeForm["accountId"];
           var str= SearchForAccIdToCloseMethod(accountIdFromUi);
            ViewBag.message = str;
            return View("CloseMessage");
            //Form --done
            //validation --
            //search  ()
            //actionResult View
        }

        public ActionResult ListOfUsers() {
           
            return View();
        }
        public ActionResult Withdraw()
        {
           
            return View();
        }
        public ActionResult Deposit()
        {

            return View();
        }


        private string SearchForAccIdToCloseMethod(string id)
        {
            string strTobeReturned = string.Empty;
            var users = Session["users"] != null ? (List<User>)Session["users"] : new List<User>();
            var x = Guid.Parse(id);

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].account.AccountId == x)
                {
                    users[i] = null;

                    strTobeReturned = "Your account Closed Successfully";
                }
                else
                {
                    strTobeReturned = "Your account Does not Exist";
                }
               
            }
            return strTobeReturned;

        }
    }
}

    
