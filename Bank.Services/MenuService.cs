﻿using System;

namespace Bank.Services
{
    public class MenuService
    {
        public void ListOptions()
        {
            Console.WriteLine("Welcome! Please Enter A Number \n\n\n" +
                "Check Your Balance..................1\n" +
                "Deposit To Your Account.............2\n" +
                "Withdrawl From Account..............3\n" +
                "Sign Out............................4");
        }
    }
}
