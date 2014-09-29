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
    
    class  Program
    {
        private static int exp;
        static   void Main(string[] args)
        {
            try
            {
                MessageOperation.ini();
                PhoneNumber phone ;
                phone = "96897615985";

                Console.WriteLine("Country Code Is{0}", phone.CountryCode.ToString());
                Console.WriteLine("PhoneNumber Is{0}", phone.PhoneNumberx.ToString());

               // Console.WriteLine(n.FullName);
                Money m="751100 Dollar";
                Name N = "Ilove You Somatch";

                Console.WriteLine(N.FirstName);
                Console.WriteLine(m.Coin);

                XpremaXmlBase.SelectedLanguge = XLanguge.English;
                MessageOperation.ini();
                Console.WriteLine(MessageOperation.SaveingMessage);
            }
            catch (XpremaException e)
            {

                Console.WriteLine(e.XpremaMessage); 
            }

            Console.WriteLine(MessageOperation.DeletedMessage); 

           // Console.Read();

                XmlFileManager xml = new XmlFileManager();
                xml.FilePath = @"x:";
                xml.FileName = "Test.txt";
                Context us = new Context();
                us.Users.Add(new User() { UserName = "yyyy", ID = 1, Password = "sdf"});
                us.Users.Add(new User() { UserName = "ABUEHAB", ID = 1, Password = "xprema" });
                us.Logins.Add(new LoginX() { LogAt = DateTime.Now, Logout = DateTime.Now, user = us.Users[0] });
                xml.Commit(us);
                List<User> pp = new List<User>();
                object o;
                Context c = new Context();
               us =(Context)xml.Load(us);
                foreach (User item in us.Users)
                {
                    Console.WriteLine(item.Password +","+item.UserName);
                }

                Console.ReadLine();

            }
           
    
           
        }
    }



