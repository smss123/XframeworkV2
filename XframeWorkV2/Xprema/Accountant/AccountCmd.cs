using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.Accountant
{
   public  class AccountCmd
    {
      static  DbAccountantDataContext db = new DbAccountantDataContext();

       public static bool NewAccount(Account tb)
       {
               db.Accounts.InsertOnSubmit(tb);
               db.SubmitChanges(); 
               return true;
       }
       public static List<Account> GetAccountByCategoryID(int Categid)
       {
           db = new DbAccountantDataContext();
           List<Account> Lst = (from c in db.Accounts
                                where c.CategoryID == Categid 
                                select c).ToList();
           return Lst;

       }
       public static bool EditAccount(Account tb)
       {

           Account q = db.Accounts.Where(p => p.ID == tb.ID).Single();
               q.AccountName = tb.AccountName;
               q.Description = tb.Description;
               q.CategoryID = tb.CategoryID;
               db.SubmitChanges();
              
               q = null;
               return true;
   
       }
       public static List<Account> GetAccountByName(string nam)
       {
           db = new DbAccountantDataContext();
           List<Account> ACT = (from ac in db.Accounts
                      where ac.AccountName == nam
                      select ac).ToList();
           return ACT;
       }
       public static bool DeleteAccount(int iD)
       {
           Account q = db.Accounts.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
               db.Accounts.DeleteOnSubmit(q);
               db.SubmitChanges();
               return true;
       }

       public static List<Account> GetAll()
       {
           return db.Accounts.ToList();
       }


       public static double GetFreeBalance(int? actid)
       {
           double NetBalance = 0;
           try
           {
               db = new DbAccountantDataContext();

               var TotIn = (from d in db.AccountDailies
                            where d.AccountID == actid
                            select d.TotalIn).Sum();

               var TotOut = (from d in db.AccountDailies
                             where d.AccountID == actid
                             select d.TotalOut).Sum();
               NetBalance = TotIn.Value - TotOut.Value;

               return NetBalance;
           }
           catch (Exception)
           {
               return NetBalance = 0;
           }
       }

       public static double? GetAccountBalance(int accountID)
       {
           var balance = (double?)0d;

           var allTotalIn = db.AccountDailies.Where(p => p.AccountID == accountID).Sum(p => p.TotalIn);
           var allTotalOut = db.AccountDailies.Where(p => p.AccountID == accountID).Sum(p => p.TotalOut);
           balance = allTotalIn - allTotalOut;

           return balance;
       }

       public static double? GetAccountBalance(int accountID, DateTime fromDate, DateTime toDate)
       {
           var balance = (double?)0d;

           var allTotalIn = db.AccountDailies.Where(
           p => p.AccountID == accountID &&
                p.DateOfProcess.Value.Year >= fromDate.Year
                && p.DateOfProcess.Value.Month >= fromDate.Month &&
                p.DateOfProcess.Value.Day >= fromDate.Day &&

                 p.DateOfProcess.Value.Year <= toDate.Year
                && p.DateOfProcess.Value.Month <= toDate.Month &&
                p.DateOfProcess.Value.Day <= toDate.Day

                ).Sum(p => p.TotalIn);
           var allTotalOut = db.AccountDailies.Where(p => p.AccountID == accountID &&
                p.DateOfProcess.Value.Year >= fromDate.Year
                && p.DateOfProcess.Value.Month >= fromDate.Month &&
                p.DateOfProcess.Value.Day >= fromDate.Day &&

                 p.DateOfProcess.Value.Year <= toDate.Year
                && p.DateOfProcess.Value.Month <= toDate.Month &&
                p.DateOfProcess.Value.Day <= toDate.Day
                ).Sum(p => p.TotalOut);
           balance = allTotalIn - allTotalOut;

           return balance;
       }



    }
}
