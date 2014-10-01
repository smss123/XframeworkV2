using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XExtention;
using Xprema.Xml;
using Xprema;
using MessagesControl;
namespace ConsoleApplicationTest
{

    class Program
    {
        private static int exp;
        static void Main(string[] args)
        {
            try
            {
                //Name na = "AbuEhab";
                //Console.WriteLine(na.FirstName + "/" + na.ScondName);
                //Console.Read();
                //PhoneNumber ph = "9709999999";
                //Console.WriteLine(ph.CountryCode);
                //Console.Read();
                //Money mo = "500.50 SDG";
                //Console.WriteLine(mo.Format());
                //Console.Read();

              Context con = new Context();
              con.Users.Add(new User() { ID = 1, Password = "123", UserName = "AbuEhab" });
              con.Users.Add(new User() { ID = 2, Password = "ADa", UserName = "sadsad" });
              con.Users.Add(new User() { ID = 3, Password = "asdsad", UserName = "asdasdsad" });
              con.Users.Add(new User() { ID = 4, Password = "asdasd", UserName = "asdsad" });
              con.Users.Add(new User() { ID = 5, Password = "ASDASD", UserName = "ASDASD" });
              XmlFileManager cmd = new XmlFileManager();
              cmd.FileName = "MyData";
              cmd.FilePath = "x:";
              cmd.Commit(con);

              
              Context cp = (Context)cmd.Load(con);

              foreach (var item in cp.Users)
              {
                  Console.WriteLine("User Is {0}", item.UserName);
              }
              Console.Read();



            }
            catch (XpremaException ex)
            {

                Console.WriteLine(ex.UserDescription);
                Console.Read();
            }
           

        }
    }
}



