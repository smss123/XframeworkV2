using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.XExtention
{
  public static  class ExInt
    {
        

        /// <summary>
        /// Convert Value float
        /// </summary>
        /// <param name="str"></param>
        /// <returns>return Type is float</returns>
        public static float ToFloat(this int str)
        {
            try
            {
                float i;
                i = float.Parse(str.ToString());
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
        public static double Todouble(this int str)
        {
            try
            {
                double i;
                i = double.Parse(str.ToString());
                return i;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        /// <summary>
        /// Convert Value To Object
        /// </summary>
        /// <param name="str"></param>
        /// <returns>return Type To Object</returns>
        public static object ToObject(this int str)
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
        public static byte ToByte(this int str)
        {
            try
            {
                byte b;
                b = byte.Parse(str.ToString());
                return b;
            }
            catch (Exception)
            {
                byte p = byte.Parse("samer");
                return p;
            }
        }
    }
}
