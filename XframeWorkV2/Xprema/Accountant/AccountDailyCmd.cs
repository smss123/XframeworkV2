using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.Accountant
{
    public class AccountDailyCmd
    {

        static DbAccountantDataContext db = new DbAccountantDataContext();

        public static bool NewAccountDaily(AccountDaily tb)
        {
       

            db.AccountDailies.InsertOnSubmit(tb);

            db.SubmitChanges();
           
            return true;
           
        }

        public static bool EditAccountDaily(AccountDaily tb)
        {

            AccountDaily q = db.AccountDailies.Where(p => p.ID == tb.ID).Single();
                q.AccountID = tb.AccountID;
                q.TotalIn = tb.TotalIn;
                q.TotalOut = tb.TotalOut;
                q.DateOfProcess = tb.DateOfProcess;
                q.Description = tb.Description;
                q.CommandArg = tb.CommandArg;
                db.SubmitChanges();
                
                return true;
          
           
        }

        public static bool DeleteAccountDaily(int iD)
        {

            AccountDaily q = db.AccountDailies.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
                db.AccountDailies.DeleteOnSubmit(q);
                db.SubmitChanges();
                return true;
        }

        public static List<AccountDaily> GetAll()
        {
            return db.AccountDailies.ToList();
        }

        public static List<AccountDaily> GetAllAccountDailyByAccountID(int actid)
        {
            db = new DbAccountantDataContext();
            List<AccountDaily> dy = (from d in db.AccountDailies
                      orderby d.DateOfProcess ascending
                      where d.AccountID == actid
                      select d).ToList();
            return dy;
        }
        public static double GetBalanceByAccountID(int ACTID)
        {
            double netBalance = 0;
            try
            {
                db = new DbAccountantDataContext();

                var totIn = (from d in db.AccountDailies
                             orderby d.DateOfProcess ascending
                             where d.AccountID == ACTID
                             select d.TotalIn).Sum();

                var totOut = (from d in db.AccountDailies
                              orderby d.DateOfProcess ascending
                              where d.AccountID == ACTID
                              select d.TotalOut).Sum();
                netBalance = totIn.Value - totOut.Value;

                return netBalance;
            }
            catch (Exception)
            {
                return netBalance = 0;
            }
        }
    }
}
