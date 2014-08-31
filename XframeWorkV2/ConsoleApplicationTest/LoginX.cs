using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationTest
{
  public   class LoginX:Xprema.Xml.XpremaXmlBase
    {
        public DateTime  LogAt { get; set; }
        public DateTime Logout { get; set; }
        public User user { get; set; }
    }
}
