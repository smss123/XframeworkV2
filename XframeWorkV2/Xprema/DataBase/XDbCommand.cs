using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Reflection;
using System.Data.Entity.Infrastructure;
namespace Xprema.DataBase
{
   public class XDbCommand:DbContext , ICommand
    {

       DbContext db ;
       private List<object> _Entities = new List<object>();

       public List<object> Entities
       {
           get { return _Entities; }
           set { _Entities = value; }
       }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           if (_Entities!=null)
           {
              
              
           }
           base.OnModelCreating(modelBuilder);
       }
       public XDbCommand(string NameOfConnectionString):base(NameOfConnectionString)
       {
           db = new DbContext(NameOfConnectionString);
           
       }
        public bool Add(object obj)
        {
            bool state = false;
            object o = obj;
           // db.Entry<>
             o = (DbEntityEntry)obj;
           
        // db.Set<Type.GetType(obj.GetType().FullName).>().Add(obj);
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
