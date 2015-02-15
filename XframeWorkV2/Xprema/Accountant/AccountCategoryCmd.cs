using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.Accountant
{
   public   class AccountCategoryCmd
    {
       static DbAccountantDataContext db = new DbAccountantDataContext();
        public static bool NewAccountCategory(AccountCategory tb)
        {
      
            db.AccountCategories.InsertOnSubmit(tb);
            db.SubmitChanges();        
            return true;

        }

        public static bool EditAccountCategory(AccountCategory tb)
        {
            //try
            //{
            AccountCategory q = db.AccountCategories.Where(p => p.ID == tb.ID).Single();
            q.AccountCategoryName = tb.AccountCategoryName;
            q.Description = tb.Description;
            db.SubmitChanges();

            return true;
  
        }

        public static bool DeleteAccountCategory(int iD)
        {

            AccountCategory q = db.AccountCategories.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
                db.AccountCategories.DeleteOnSubmit(q);
                db.SubmitChanges();
            
                return true;
         
        }

        public static List<AccountCategory> GetAll()
        {
            return db.AccountCategories.ToList();
        }

        public static AccountCategory GetAccountCategoryByID(int xid)
        {
            AccountCategory CategTb = db.AccountCategories.Where(p => p.ID == xid).Single();

            return CategTb;
        }

    }
}
