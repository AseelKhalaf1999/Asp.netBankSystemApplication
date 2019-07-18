using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebBankSystemApplication.Models
{
    public class User
    {

        //Attributes
        public int Age;

        //object Account
        public Account account = new Account();

        //Constructor
        public User(String Name, String Email, DateTime DOB, int Age, string gender,double Balance)
        {
            this.Name = Name;
            this.Email = Email;
            this.DOB = DOB;
            this.Age = Age;
            this.gender = gender;
            this.Balance = Balance;
        }
        //EmptyConstructor
        public User()
        {
        }

        //Enum Gender Method
        //public enum Gender
        //{
        //    Male, Female
        //}
        //Setters And Getters
        [Required]
        [Display(Name = "Enter lastname")] 
        public String Name { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        public String Email { get; set; }
     
        public DateTime DOB { get; set; }
        public int AgeGetSet { get; set; }
        [Required(ErrorMessage = "Enter Gender")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Enter Balance")]
        public double Balance { get; set; }


    }
}