using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Reflection;
namespace Xprema.DataBase
{
   public class XDbCommand:XpremaBaseClass , ICommand
    {
       private DbContext db;
       public XDbCommand(string NameOfConnectionString)
       {
           db = new DbContext(NameOfConnectionString);
       }
        public bool Add(object obj)
        {
            bool state = false;
            object o = obj;

            //db.Set<Activator.GetObject(o.GetType(),o.GetType().FullName)>();
            return state;
        }

        public bool Edit(object obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
