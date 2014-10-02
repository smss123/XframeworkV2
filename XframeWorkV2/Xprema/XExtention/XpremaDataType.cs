using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.XExtention
{
   public static class ExXpremaDataType
    {
       public static string  ToString(this PhoneNumber str)
       {
           return str.GetFullPhoneNumber();
       }

       /// <summary>
       ///  To Formate The Phone Number To May Formating
       /// </summary>
       /// <param name="str">PhoneNumber</param>
       /// <param name="formate">formate Like 000-000 or Other</param>
       /// <returns></returns>
       public static string  Formate( this PhoneNumber str,string formate)
       {
           if (formate=="000-000")
           {
               return str.CountryCode + "-" + str.PhoneNumberx;
           }
           else
           {
               return str.GetFullPhoneNumber();
           }
       }


    }
}
