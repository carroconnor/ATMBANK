using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Bank.Services
{
    public class ClientService
    {



        public bool CreateClient(string first, string last, int id)
        {
            using (var ctx = new AtmBankEntities())
            {
                var entity =
                    new Client
                    {
                        FirstName = first,
                        LastName = last,
                        ClientID = id
                    };
                ctx.Clients.Add(entity);
                return ctx.SaveChanges() == 1;

            }

        }


        private MenuService menuservice = new MenuService();
        private AtmBankEntities db = new AtmBankEntities();
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


