using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Xprema.XExtention
{
 public static   class ExString
    {

     /// <summary>
     /// Convert Value To integer
     /// </summary>
     /// <param name="str"></param>
     /// <returns>return Type Is int</returns>
     public static int ToInt(this string str)
     {
         try
         {
             int i;
             i = int.Parse(str);
             return i;
         }
         catch (Exception)
         {

             return 0;
         }
     }

     /// <summary>
     /// Convert Value float
     /// </summary>
     /// <param name="str"></param>
     /// <returns>return Type is float</returns>
     public static float ToFloat(this string str)
     {
         try
         {
             float i;
             i = float.Parse(str);
             return i;
         }
         catch (Exception)
         {

             return 0;
         }
     }

     /// <summary>
     /// Convert Value To Double
     /// </summary>
     /// <param name="str"></param>
     /// <returns>return Type is double</returns>
     public static double Todouble(this string str)
     {
         try
         {
             double i;
             i = double.Parse(str);
             return i;
         }
         catch (Exception)
         {
             return 0;
         }

     }

     /// <summary>
     /// Convert Value To DateTime
     /// </summary>
     /// <param name="str"></param>
     /// <returns>Return Type is Datetime</returns>
     public static DateTime ToDateTime(this string str)
     {
         try
         {
             DateTime  i;
             i = DateTime.Parse(str);
             return i;
         }
         catch (Exception)
         {
             return DateTime.Now;
         }
     }

     /// <summary>
     /// Convert Value To Xml Document
     /// </summary>
     /// <param name="str"></param>
     /// <returns></returns>
     public static XmlDocument ToXml(this string str)
     {
         try
         {
             XmlDocument doc = new XmlDocument();
             doc.LoadXml(str);
             return doc;
         }
         catch (Exception)
         {

             return null;
         }
     }

     /// <summary>
     /// Convert Value To Object
     /// </summary>
     /// <param name="str"></param>
     /// <returns>return Type To Object</returns>
     public static object ToObject(this string str)
     {
         try
         {
             object obj = str;
             return obj;

         }
         catch (Exception)
         {

             return null;
         }
     }

     /// <summary>
     /// Convert Value To Byte
     /// </summary>
     /// <param name="str"></param>
     /// <returns>Return Type Is Byte</returns>
     public static byte ToByte(this string str)
     {
         try
         {
             byte b;
             b = byte.Parse(str);
             return b;
         }
         catch (Exception)
         {
             byte p= byte.Parse("samer");
             return p;
         }
     }

    }
}
