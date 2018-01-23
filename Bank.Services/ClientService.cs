using System;
using System.Linq;
using Bank.Models;

namespace Bank.Services
{
    public class ClientService
    {

        private MenuService menuservice = new MenuService();
        private AtmBankEntities db = new AtmBankEntities();

        public bool CreateClient(string first, string last)
        {
            using (var ctx = new AtmBankEntities())
            {
                var entity =
                    new Client
                    {
                        FirstName = first,
                        LastName = last
                    };

                ctx.Clients.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public bool VerifyUser(int acctNum, int pin)
        {
            var query = from a in db.Accounts
                        where a.Account_ == acctNum && a.Pin == pin
                        select a;

            foreach (var a in query)
            {
                menuservice.ListOptions();
                return true;
            }

            Console.WriteLine("Incorrect Username or Pin");
            return false;
        }
    }
}


