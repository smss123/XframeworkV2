using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.Xml;
namespace ConsoleApplicationTest
{
  public   class User:XpremaXmlBase
    {
        public int ID { get; set; }
        public string  UserName { get; set; }
        public string  Password { get; set; }
        public virtual List<LoginX> Logins { get; set; }
    }
}
