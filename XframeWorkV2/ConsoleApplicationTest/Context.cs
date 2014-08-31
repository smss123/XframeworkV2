using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationTest
{
  public  class Context
    {
        public List<User> Users { get; set; }
        public List<LoginX> Logins { get; set; }
        public Context()
        {
            this.Users = new List<User>();
            this.Logins = new List<LoginX>();
        }
    }
}
