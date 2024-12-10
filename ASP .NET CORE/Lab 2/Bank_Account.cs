using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2
{
    internal class Bank_Account
    {

        public int Account_No;
        public string Email;
        public string User_Name;
        public string Account_Type;
        public int Account_Balance;

        public void GetBankDetails()
        {
            Console.WriteLine("Enter Bank_Account Details:");
            Console.Write("Account_No : ");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email : ");
            Email = Console.ReadLine();
            Console.Write("User_Name : ");
            User_Name = Console.ReadLine();
            Console.Write("Account_Type (Savings or Current) : ");
            Account_Type = Console.ReadLine();
            Console.Write("Account_Balance : ");
            Account_Balance = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayBankDetails()
        {
            Console.WriteLine("\nBank_Account Details:");
            Console.WriteLine($"Account_No : {Account_No}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"User_Name : {User_Name}");
            Console.WriteLine($"Account_Type : {Account_Type} Account");
            Console.WriteLine($"Account_Balance : {Account_Balance} ");
        }

    }
}
