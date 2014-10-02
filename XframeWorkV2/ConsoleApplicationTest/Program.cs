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
                Name na = "AbuEhab Abu Abu";
                Console.WriteLine(na);
                Console.Read();
                PhoneNumber ph = "9709999999";
                Console.WriteLine(ph.Formate("000-000"));
                Console.Read();
                Money mo = "500.50 SDG";
                Console.WriteLine(mo.Format());
                Console.Read();
               
              Context con = new Context();
              Console.WriteLine("Loading ..");
              //for (int i = 0; i <= 1000000; i++)
              //{
              //     con.Users.Add(new User() { ID = i, Password = "Pa$$wr0rd", UserName = "Samer Abd ulla" });
              //}
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



