using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebBankSystemApplication.Models
{
    public class Bank
    {
        //Setters and Getters
        public String BankName { get; set; }
        public int BankId { get; set; }
        public String Address { get; set; }
        public int BankPhoneNumber { get; set; }


        //List Of Users
        public List<User> users = new List<User>();
        //String Builder to see the error
        StringBuilder track = new StringBuilder();
        //Constructors
        public Bank()
        {

            users = new List<User>();


        }
        public Bank(String BankName, int BankId, String Address, int BankPhoneNumber)
        {
            this.BankName = BankName;
            this.BankId = BankId;
            this.Address = Address;
            this.BankPhoneNumber = BankPhoneNumber;

        }
        //open Account
        //public User CreateAccount(String Name, String Email, String gender, double balance)
        //{

        //        User userobject = new User();
        //        userobject.Name = Name;
        //        userobject.Email = Email;
        //        //userobject.DOB = Convert.ToDateTime(date);
        //        userobject.Age = CalculateAge(userobject.DOB);
        //        Guid id = Guid.NewGuid();
        //        userobject.account.AccountId = id;
        //        userobject.account.Balance = balance;
        //    return userobject;
        //    }

        //List<String> arr = new List<string>();
        //arr.Add(Name);
        //arr.Add(Email);
        //arr.Add(date);
        //arr.Add(Name);
        //arr.Add(Name);

        //Console.WriteLine("Enter You Name :");
        //arr.Add(Console.ReadLine());
        //Console.WriteLine("Enter You Email :");
        //arr.Add(Console.ReadLine());
        //Console.WriteLine("Enter You Date Of Birth :");
        //arr.Add(Console.ReadLine());
        //Console.WriteLine("Enter You Gender :");
        //arr.Add(Console.ReadLine());
        //Console.WriteLine("Enter Balance to Open Your Account with :");
        //arr.Add(Console.ReadLine());


        //to check if the input is valid or not



        //bool validNamee = checkvalidtyName(arr[0]);
        //bool validEmail = CheckValidtyEmail(arr[1]);
        //bool validAge = checkedValidtyAge(Convert.ToDateTime(arr[2]));
        //bool validGender = CheckValidityGender(arr[3]);
        //bool validBalance = CheckValidityBalance(Convert.ToDouble(arr[4]));




        //if (validNamee && validEmail && validAge && validGender && validBalance)
        //{
        //    User userobject = new User();

        //    userobject.Name = arr[0].ToString();
        //    userobject.Email = arr[1].ToString();
        //    userobject.DOB = Convert.ToDateTime(arr[2]);
        //    userobject.Age = CalculateAge(userobject.DOB);
        //    User.Gender genderEnum = new User.Gender();

        //    if (arr[3] == "")
        //    {
        //    Console.BackgroundColor = ConsoleColor.Red;
        //    String alert = "ERROR IN GENDER ! You didn't type your gender ! you should type it \n";
        //    track.Append(alert);
        //    Console.ResetColor();

        //}

        //else if (arr[3] == "M" || arr[3] == "m" || arr[3] == "male" || arr[3] == "MALE")
        //{

        //    genderEnum = User.Gender.Male;
        //    userobject.gender = genderEnum;


        //}
        //        else if (arr[3] == "F" || arr[3] == "f" || arr[3] == "female" || arr[3] == "FEMALE")
        //        {
        //            genderEnum = User.Gender.Female;
        //            userobject.gender = genderEnum;

        //        }
        //        else
        //        {
        //            Console.BackgroundColor = ConsoleColor.Red;
        //            String alert = "ERROR IN Gender !Your Gender should be : male/female or you can just type f or m ...! \n ";
        //            track.Append(alert);
        //            Console.ResetColor();

        //        }

        //        Guid id = Guid.NewGuid();
        //        userobject.account.AccountId = id;
        //        userobject.account.Balance = Convert.ToDouble(arr[4]);

        //        Console.ForegroundColor = ConsoleColor.Green;


        //        Console.WriteLine("Your Account has been created Successfuly and your Id is: {0}", userobject.account.AccountId);
        //        Console.ResetColor();
        //        users.Add(userobject);

        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine(" Mistakes in Your input Are :\n");
        //        Console.WriteLine(track);
        //        Console.WriteLine("Correct Them Kindly !!");
        //        Console.ResetColor();
        //        if (!validNamee)
        //        {
        //            Console.WriteLine("Your Name Again:");
        //            String name = Console.ReadLine();
        //            bool yes = checkvalidtyName(name);
        //            while (!yes)
        //            {
        //                Console.WriteLine("Not Correct again ! type your name :");
        //                String name1 = Console.ReadLine();
        //                if (checkvalidtyName(name1))
        //                {
        //                    yes = !yes;
        //                }
        //                else
        //                    continue;

        //            }
        //            Console.ForegroundColor = ConsoleColor.Green;
        //            Console.WriteLine("Your Name Has been edited Successfully");
        //            Console.ResetColor();

        //        }
        //        if (!validEmail)
        //        {
        //            Console.WriteLine("Your Email Again :");
        //            String email = Console.ReadLine();
        //            bool yes = CheckValidtyEmail(email);
        //            while (!yes)
        //            {
        //                Console.WriteLine("Not Correct again ! type your email :");
        //                String name1 = Console.ReadLine();
        //                if (CheckValidtyEmail(name1))
        //                {
        //                    yes = !yes;
        //                }
        //                else
        //                    continue;

        //            }
        //            Console.ForegroundColor = ConsoleColor.Green;
        //            Console.WriteLine("Your Email Has been edited Successfully");
        //            Console.ResetColor();




        //        }

        //        if (!validGender)
        //        {
        //            Console.WriteLine("Your GENDER Again :");
        //            String gender = Console.ReadLine();
        //            bool yes = CheckValidityGender(gender);
        //            while (!yes)
        //            {
        //                Console.WriteLine("Not Correct again ! type your gender :");
        //                String name1 = Console.ReadLine();
        //                if (CheckValidityGender(name1))
        //                {
        //                    yes = !yes;
        //                }
        //                else
        //                    continue;

        //            }
        //            Console.ForegroundColor = ConsoleColor.Green;
        //            Console.WriteLine("Your Gender Has been edited Successfully");
        //            Console.ResetColor();

        //        }

        //        //else { }

        //        if (!validAge)
        //        {
        //            Console.WriteLine("Your DOB Again :");
        //            DateTime date = Convert.ToDateTime(Console.ReadLine());
        //            bool yes = checkedValidtyAge(date);
        //            while (!yes)
        //            {
        //                Console.WriteLine("Not Correct again ! type your Date Of Birth :");
        //                DateTime date1 = Convert.ToDateTime(Console.ReadLine());
        //                if (checkedValidtyAge(date1))
        //                {
        //                    yes = !yes;
        //                }
        //                else
        //                    continue;

        //            }
        //            Console.ForegroundColor = ConsoleColor.Green;
        //            Console.WriteLine("Your Date Of Birth  Has been edited Successfully");
        //            Console.ResetColor();

        //        }

        //        //else { }
        //        if (!validBalance)
        //        {
        //            Console.WriteLine("Your Balance Again :");
        //            double balance = Convert.ToDouble(Console.ReadLine());
        //            bool yes = CheckValidityBalance(balance);
        //            while (!yes)
        //            {
        //                Console.WriteLine("Not Correct again ! type  Balance more than 2000 :");
        //                String name1 = Console.ReadLine();
        //                if (checkvalidtyName(name1))
        //                {
        //                    yes = !yes;
        //                }
        //                else
        //                    continue;

        //            }
        //            Console.ForegroundColor = ConsoleColor.Green;
        //            Console.WriteLine("Your Balance Has been edited Successfully");
        //            Console.ResetColor();

        //        }
        //    }




        //}







        ////check age validity
        //private bool checkedValidtyAge(DateTime DOB)
        //{
        //    int age = CalculateAge(DOB);
        //    if (age <= 15 || age < 1)
        //    {
        //        String message = (" Sorry For Telling You That We can't Open An Account For You Because Your Age Is Under 15 \n");
        //        track.Append(message);
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        ////calculate user age from dob
        //public int CalculateAge(DateTime dob)
        //{
        //    DateTime todayy = DateTime.Today;

        //    int agee = todayy.Year - dob.Year;

        //    return agee;
        //}


        ////check name validity
        //private bool checkvalidtyName(String Name)
        //{
        //    bool answer = Regex.IsMatch(Name, @"^[a-zA-Z\s]+$");
        //    if (answer)
        //    {
        //        return true;
        //    }
        //    else if (Name == "")
        //    {
        //        String alert = "ERROR IN NAME ! You didn't type your name ! you should type it \n";
        //        track.Append(alert);
        //        return false;
        //    }
        //    else
        //    {
        //        String alert = "ERROR IN NAME ! Your Name should only include characters \n";
        //        track.Append(alert);
        //        return false;

        //    }

        //}
        ////check email validty
        //private bool CheckValidtyEmail(String email)
        //{

        //    bool ValidEmail = Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
        //    if (ValidEmail)
        //    {
        //        return true;
        //    }
        //    else if (email == "")
        //    {
        //        String alert = "ERROR IN EMAIL ! You didn't type your email ! you should type it";
        //        track.Append(alert);
        //        return false;
        //    }
        //    else
        //    {
        //        String alert = "ERROR IN EMAIL !Your Email Pattern should be : example@example.example ";
        //        track.Append(alert);
        //        return false;

        //    }

        //}
        ////check Gender Validity

        //private bool CheckValidityGender(String gender)
        //{
        //    if (gender == "")
        //    {
        //        Console.BackgroundColor = ConsoleColor.Red;
        //        String alert = "ERROR IN GENDER ! You didn't type your gender ! you should type it";
        //        track.Append(alert);
        //        Console.ResetColor();
        //        return false;
        //    }

        //    else if (gender == "M" || gender == "m" || gender == "male" || gender == "MALE")
        //    {

        //        return true;
        //    }
        //    else if (gender == "F" || gender == "f" || gender == "female" || gender == "FEMALE")
        //    {

        //        return true;
        //    }
        //    else
        //    {
        //        String alert = "ERROR IN Gender !Your Gender should be : male/female or you can just type f or m ...! ";
        //        track.Append(alert);
        //        return false;
        //    }
        //}
        ////to check the validty of the balance
        //private bool CheckValidityBalance(double balance)
        //{
        //    String balanceStr = balance.ToString();
        //    bool BalanceValid = Regex.IsMatch(balanceStr, @"[0-9]+");
        //    if (balanceStr == "")
        //    {
        //        String alert = "ERROR IN BALANCE ! You didn't type your balance to open your account ! you should type it";
        //        track.Append(alert);
        //        return false;
        //    }
        //    else if (BalanceValid)
        //    {
        //        //if the number is > 2000
        //        bool correctCase = IsGreater(balanceStr);
        //        if (correctCase)
        //        {

        //            return true;

        //        }
        //        else
        //        {
        //            String alert = "ERROR IN BALANCE ! the balance you entered is not valid ! your balance should be more than 2000";
        //            track.Append(alert);
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        String alert = "ERROR IN BALANCE ! You Should only insert Numbers !";
        //        track.Append(alert);
        //        return false;
        //    }


        //}


        ////Method To check if the Balance is greater than 2000
        //private static bool IsGreater(string balance)
        //{
        //    if (Convert.ToInt16(balance) <= 2000)
        //    {
        //        return false;
        //    }
        //    else { return true; }
        //}

        ////Method To Close An Account 
        //public void CloseAccount()
        //{
        //    if (users.Count > 0)
        //    {
        //        users[0] = null;
        //        Console.ForegroundColor = ConsoleColor.Green;

        //        Console.WriteLine("Your Account has been closed! we love to see you again opening another account");
        //        Console.ResetColor();



        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;

        //        Console.WriteLine("You don't even have an account to close!");
        //        Console.ResetColor();


        //    }

        //}


        //// method to withdraw from account
        //public void withdraw()
        //{
        //    Console.WriteLine("your balance before withdraw : " + users[0].account.Balance);
        //    double amount;
        //    Console.WriteLine("enter the amount you want to withdraw ");
        //    amount = Convert.ToDouble(Console.ReadLine());

        //    if (amount < 50)
        //    {
        //        Console.WriteLine("sorry you can't withdraw this amount ! the amount should be at least 50  ");
        //    }
        //    else if (amount > users[0].account.Balance)
        //    {
        //        Console.WriteLine("sorry , your balance is only " + users[0].account.Balance + "the amount you entered is larger than your balance");
        //    }
        //    else
        //    {
        //        double modifiedbalance = users[0].account.Balance - amount;
        //        users[0].account.Balance = modifiedbalance;
        //        Console.WriteLine("your balance after this transaction is " + modifiedbalance);



        //    }

        //}


        ////Method To Deposit Into Account
        //public void Deposit()
        //{
        //    Console.WriteLine("Your Balance Before deposit is : " + users[0].account.Balance);
        //    double amount;
        //    Console.WriteLine("Enter The amount you want to deposite ");

        //    amount = Convert.ToDouble(Console.ReadLine());

        //    if (amount <= 0)
        //    {
        //        Console.WriteLine("Sorry This amount is less than 0 ! you can't deposite it");
        //    }

        //    else
        //    {
        //        double modifiedBalance = users[0].account.Balance + amount;
        //        users[0].account.Balance = modifiedBalance;
        //        Console.WriteLine("Your Balance After this transaction is " + modifiedBalance);

        //    }
        //}
        ////Print Users From The list
        //public List<User> AllUsers()
        //{
        //    //list of users who have accounts
        //    int i = 0;
        //    foreach (User user in users)
        //    {

        //        Console.ForegroundColor = ConsoleColor.Cyan;
        //        Console.WriteLine("User  Number {0} Details : ", i + 1);
        //        Console.WriteLine("Name: {0} , Email: {1} , Age: {2} , Gender: {3} , Date Of Birth: {4}  ", user.Name, user.Email, user.Age, user.gender, user.DOB);
        //        Console.WriteLine("AccountId: {0} , Balance: {1}", user.account.AccountId, user.account.Balance);
        //        Console.WriteLine();

        //    }
        //    Console.ResetColor();

        //    //Users Orderd By age
        //    var usersOrderByAge = users.OrderByDescending(x => x.Age);
        //    foreach (User user in usersOrderByAge)
        //    {
        //        Console.WriteLine("Name: {0}  , Age: {1} ", user.Name, user.Age);
        //        Console.WriteLine();

        //    }


        //    ////Queries
        //    //var useresWithBalanceAbove6000 = users.Where(x => x.account.Balance > 6000).FirstOrDefault();
        //    //Console.WriteLine("useresWithBalanceAbove6000: {0}", useresWithBalanceAbove6000.Email);

        //    //var alluserswithageAbove20 = users.Where(y => y.Age > 20).FirstOrDefault();
        //    //Console.WriteLine("Users With age above 20 {0}", alluserswithageAbove20.Name);


        //    //  Console.WriteLine("sorted list of users due to age  {0}", usersOrderByAge.ToString());


        //    // Console.ReadLine();



        //    return users;
        //}
        //Method to view Bank Details 
        public void viewBankDetails()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;


            Console.WriteLine("Bank Name Is: ArabBank \n Bank Id is: 23332244 \n Address is : Ramallah-Nablus Street \n Phone Number: 05998736363 ");
            Console.ResetColor();
        }
        //Just to view the user's balance
        public void viewBalance()
        {
            Console.WriteLine("Your Balance is {0}", users[0].Balance);
        }
    }
}


