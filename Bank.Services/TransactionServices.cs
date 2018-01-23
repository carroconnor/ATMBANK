using System.Linq;
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
            }

        }

        public decimal MakeDeposit(int acctNum, int pin, decimal depositAmt)
        {
            decimal DepositAmt = depositAmt;
            using (var ctx = db)
            {
                var query =
                     from a in ctx.Accounts
                     where a.Account_ == acctNum && a.Pin == pin
                     select a;
                var account = query.Single();

                account.Balance = account.Balance + DepositAmt;

                ctx.SaveChanges();

                return account.Balance;
            }
        }

        public decimal MakeWithdrawl(int acctNum, int pin, decimal withdrawlAmt)
        {
            decimal WithdrawlAmt = withdrawlAmt;
            using (var ctx = db)
            {
                var query =
                    from a in ctx.Accounts
                    where a.Account_ == acctNum && a.Pin == pin
                    select a;
                var account = query.Single();

                account.Balance = account.Balance - WithdrawlAmt;

                ctx.SaveChanges();

                return account.Balance;
            }
        }
    }
}
