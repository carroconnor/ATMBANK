using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Services;

namespace Bank.ATMConsole
{
    public class AccountController
    {
        public static void GetAccount(int acctNum, int pin)
        {
            TransactionServices svc = new TransactionServices();
            var currentUser = svc.GetAccount(acctNum, pin);
            Console.WriteLine("Your balance is : $" + currentUser.Balance);
        }

        public static void GetDeposit(int acctNum, int pin)
        {
            TransactionServices svc = new TransactionServices();
            var currentUser = svc.GetAccount(acctNum, pin);
            decimal deposit = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Your current balance is : $" + (currentUser.Balance + deposit));
            
            
        }

        public static void GetWithdrawl(int acctNum, int pin)
        {
            TransactionServices svc = new TransactionServices();
            var currentUser = svc.GetAccount(acctNum, pin);
            decimal withdrawl = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Your Current Balance is : $" + (currentUser.Balance - withdrawl));
        }

    }
}
