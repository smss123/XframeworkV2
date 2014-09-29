using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.Xml;
using Xprema.XExtention;
namespace ConsoleApplicationTest
{
  public   class User:XpremaXmlBase,IAutoNumber
    {
     
      
        public string  UserName { get; set; }
        public string  Password { get; set; }
        public virtual List<LoginX> Logins { get; set; }

       private static int _ID;
        public int ID
        {
            get
            {

                return _ID;
            }
            set
            {
                if (_ID==0)
                {
                    _ID = 1;
                }
                _ID+=1;
            }
        }
    }
}
