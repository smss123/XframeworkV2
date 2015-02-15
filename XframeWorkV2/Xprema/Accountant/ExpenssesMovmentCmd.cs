using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.Accountant
{
   public  class ExpenssesMovmentCmd
    {

       static DbAccountantDataContext db = new DbAccountantDataContext();
       public static bool NewExpenssesMovment(ExpenssesMovment tb)
       {

               db.ExpenssesMovments.InsertOnSubmit(tb);
               db.SubmitChanges();
               return true ;
       }

       public static bool EditExpenssesMovment(ExpenssesMovment tb)
       {

           ExpenssesMovment q = db.ExpenssesMovments.Where(p => p.ID == tb.ID).Single();
               q.ExpenssesID = tb.ExpenssesID;
               q.Amount = tb.Amount;
               q.DateOfProcess = tb.DateOfProcess;
               q.Description = tb.Description;
               return true;

              
       }

       public static bool DeleteExpenssesMovment(int iD)
       {
        
               var q = db.ExpenssesMovments.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
               db.ExpenssesMovments.DeleteOnSubmit(q);
               db.SubmitChanges();
               return true;
       }

       public static List<ExpenssesMovment> GetAll()
       {
           return db.ExpenssesMovments.ToList();
       }

       public static List<ExpenssesMovment> GetAllExpenssesMovmentByExpID(int expID)
       {


           List<ExpenssesMovment> LST = (from c in db.ExpenssesMovments
                      where c.ExpenssesID == expID
                      select c).ToList();
           return LST;
       }
    }
}
