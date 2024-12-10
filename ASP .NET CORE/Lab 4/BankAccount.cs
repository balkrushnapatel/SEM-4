using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class BankAccount
    {
        string name;
        double balance;

        public BankAccount(string n, double b) 
        {
            name = n;
            balance = b;
        }

        public double DepositByCash(double x)
        {
            return balance + x;
        }

        public double WithdrawByCash(double x)
        {
            return balance - x;
        }

        public double DepositByCheck(double x)
        {
            return balance + x;
        }

        public double WithdrawByheck(double x)
        {
            return balance - x;
        }
    }
}
