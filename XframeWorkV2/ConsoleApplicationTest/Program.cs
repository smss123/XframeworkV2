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

    public class Program
    {
        private static int exp;
        static void Main(string[] args)
        {
            try
            {
                XName na = "sharaf mohammed";
                Console.WriteLine(na.LastName);
                Console.Read();
                XPhoneNumber ph = "249911179738";
                Console.WriteLine(ph.CountryCode);
                Console.Read();
                XMoney mo = "500.50 SDG";
                Console.WriteLine(mo.Format());
                Console.Read();
               
              Context con = new Context();
              Console.WriteLine("Loading ..");
              for (int i = 0; i <= 100; i++)
              {
                  con.Users.Add(new User() { ID = i, Password = "Pa$$wr0rd", UserName = "Samer Abd ulla" });
              }
              XmlFileManager cmd = new XmlFileManager();
              cmd.FileName = "Shaf";
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



