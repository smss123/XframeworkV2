using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XExtention;
using Xprema.Xml;

namespace ConsoleApplicationTest
{
    
    class  Program
    {
        static   void Main(string[] args)
        {
            
                XmlFileManager xml = new XmlFileManager();
                xml.FilePath = @"x:\";
                xml.FileName = "Test.txt";
                Context us = new Context();
            /*var ls = new List<LoginX>().Add(new LoginX(){
                 LogAt= DateTime.Now.AddDays(1),
                  Logout = DateTime.Now.AddDays(2),
                   user= us.Users[0]
                });*/
                us.Users.Add(new User() { UserName = "samer", ID = 1, Password = "sdf"});
                us.Users.Add(new User() { UserName = "ABUEHAB", ID = 2, Password = "xprema" });
                us.Logins.Add(new LoginX() { LogAt = DateTime.Now, Logout = DateTime.Now, user = us.Users[0] });

                xml.Commit(us);
                List<User> pp = new List<User>();
                object o = pp;
                pp = xml.Load(o);
                foreach (User item in (List<User>)o)
                {
                    Console.WriteLine(item.Password +","+item.UserName);
                }
                Console.Read();

            }
           
    
           
        }
    }

}
}
