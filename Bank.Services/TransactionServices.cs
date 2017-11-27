using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Bank.Services
{
    public class TransactionServices
    {
        public AtmBankEntities db = new AtmBankEntities();

        public Account GetAccount(int acctNum, int pin)
        {
            using (db)
            {
                return
                db
                    .Accounts
                    .Where(e => e.Account_ == acctNum && e.Pin == pin)
                    .Single();
                
                db.SaveChanges(); 
               
            }
            
        }
        

    }
}
