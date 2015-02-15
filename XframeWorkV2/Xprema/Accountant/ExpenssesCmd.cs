using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.Accountant
{
    public class ExpenssesCmd
    {

        static DbAccountantDataContext db = new DbAccountantDataContext();
        public static bool NewExpensses(Expenss tb)
        {
            db.Expensses.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
    
        }

        public static bool EditExpensses(Expenss tb)
        {

            Expenss q = db.Expensses.Where(p => p.ID == tb.ID).Single();
            q.ExpenssesName = tb.ExpenssesName;
            q.Description = tb.Description;
            db.SubmitChanges();
            return true;
        }

        public static bool DeleteExpensses(int iD)
        {
            db = new DbAccountantDataContext();
            Expenss q = db.Expensses.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
                db.Expensses.DeleteOnSubmit(q);
                db.SubmitChanges();
               return true ;
        }

        public static List<Expenss> GetAll()
        {
            db = new DbAccountantDataContext();
            return db.Expensses.ToList();
        }

        public static Expenss GetById(int expid)
        {
            db = new DbAccountantDataContext();
            Expenss GetOneExpensse = (from c in db.Expensses
                                  where c.ID == expid
                                  select c).SingleOrDefault();
            return GetOneExpensse;
        }

    }
}
