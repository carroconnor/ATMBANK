using System;
using System.Threading;
using Bank.Services;

namespace Bank.ATMConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientService client = new ClientService();
            client.CreateClient("Carr", "OConnor");

            ClientService clientService = new ClientService();

            Console.WriteLine("$ Welcome to O'Connor's World Bank $");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(600);

            Console.WriteLine("Please enter your Account Number");
            int acctNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter you Pin");
            int pin = int.Parse(Console.ReadLine());
            Console.Clear();

            clientService.VerifyUser(acctNum, pin);

            decimal choice = decimal.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AccountController.GetAccount(acctNum, pin);
                    break;

                case 2:

                    Console.WriteLine("How much would you like to deposit?");
                    AccountController.GetDeposit(acctNum, pin);
                    break;

                case 3:
                    Console.WriteLine("How Much Would You Like to Withdrawl?");
                    AccountController.GetWithdrawl(acctNum, pin);
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Have A Great Day");
                    break;
            }
            Console.ReadLine();
        }
    }
}
