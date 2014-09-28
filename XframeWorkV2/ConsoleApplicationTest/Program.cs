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
                PhoneNumber phone ;
                
                //phone.SetFullNumber("96897615985");
                //Console.WriteLine("Country Code Is{0}", phone.CountryCode.ToString());
                //Console.WriteLine("PhoneNumber Is{0}", phone.PhoneNumberx.ToString());

               // Console.WriteLine(n.FullName);
                Money m;
                m.Coin = "$";
                m.Amount = 500d;

                XpremaXmlBase.SelectedLanguge = XLanguge.English;
                MessageOperation.ini();
                Console.WriteLine(MessageOperation.SaveingMessage);
            }
            catch (XpremaException e)
            {

                Console.WriteLine(e.XpremaMessage); 
            }
             

            Console.Read();

                XmlFileManager xml = new XmlFileManager();
                xml.FilePath = @"x:\";
                xml.FileName = "Test.txt";
                Context us = new Context();
                us.Users.Add(new User() { UserName = "yyyy", ID = 1, Password = "sdf"});
                us.Users.Add(new User() { UserName = "ABUEHAB", ID = 2, Password = "xprema" });
                us.Logins.Add(new LoginX() { LogAt = DateTime.Now, Logout = DateTime.Now, user = us.Users[0] });
                xml.Commit(us);
                List<User> pp = new List<User>();
                object o;
                o = xml.Load(pp);
                foreach (User item in (List<User>)o)
                {
                    Console.WriteLine(item.Password +","+item.UserName);
                }
                Console.Read();

            }
           
    
           
        }
    }



