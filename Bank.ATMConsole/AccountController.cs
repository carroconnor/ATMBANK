using System;
using Bank.Services;

namespace Bank.ATMConsole
{
    public class AccountController
    {
        public static TransactionServices transactionService = new TransactionServices();
        public static void GetAccount(int acctNum, int pin)
        {
            var currentUser = transactionService.GetAccount(acctNum, pin);
            Console.WriteLine("Your balance is : $" + currentUser.Balance);
        }

        public static void GetDeposit(int acctNum, int pin)
        {
            decimal depositAmt = decimal.Parse(Console.ReadLine());
            var currentUser = transactionService.MakeDeposit(acctNum, pin, depositAmt);
            Console.WriteLine("Your new balance is : $" + currentUser);
        }

        public static void GetWithdrawl(int acctNum, int pin)
        {
            decimal withdrawlAmt = decimal.Parse(Console.ReadLine());
            var currentUser = transactionService.MakeWithdrawl(acctNum, pin, withdrawlAmt);
            Console.WriteLine("Your new balance is : $" + currentUser);
        }
    }
}
