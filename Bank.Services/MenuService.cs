using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    class MenuService
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
