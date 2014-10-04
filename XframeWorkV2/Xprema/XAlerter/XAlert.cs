using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XExtention;
namespace Xprema.XAlerter
{
  public  class XAlert
    {
      public int ID
      {
          get
          {
             unchecked
              {
                  return string.Format("{0}", DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond).ToInt();
              }
         }
      }

      public string  AlertCaption { get; set; }
      public string  Summary { get; set; }
      public string  Description { get; set; }
      public DateTime  CreatedDate { get; set; }
      public DateTime  AlertDate { get; set; }
    }
}
