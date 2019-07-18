using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebBankSystemApplication.Models
{
    public class Account
    {
        public Account(Guid AccountId)
        {
            this.AccountId = AccountId;
           
        }

        public Account()
        {
        }

        //Setters And Getters
        public Guid AccountId { get; set; }
       
       
    }
}