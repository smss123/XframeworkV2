using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema
{
  public  class XpremaException:Exception
    {
        public int CodeNumber { get; set; }
        public string  XpremaMessage { get; set; }
        public string  OtherDescription { get; set; }
        public string UserDescription { get; set; }
        public string UserDescriptionArabic { get; set; }
      public XpremaException()
      {
            //ToDo:SendEmail     
      }

      public XpremaException(string msg):base(msg)
      {

      }

      public XpremaException(string msg,int code):base(msg)
      {
          this.XpremaMessage = msg;
          this.CodeNumber = code;
      }
      public XpremaException(string msg,int code,string other):base(msg)
      {
          this.XpremaMessage = msg;
          this.OtherDescription = other;
          this.CodeNumber = code;
      }

      public XpremaException(string msg, int code, string other,string UserMessage)
          : base(msg)
      {
          this.XpremaMessage = msg;
          this.OtherDescription = other;
          this.CodeNumber = code;
          this.UserDescription = UserMessage;
      }

      public XpremaException(string msg, int code, string other, string UserMessage,string UserArabic)
          : base(msg)
      {
          this.XpremaMessage = msg;
          this.OtherDescription = other;
          this.CodeNumber = code;
          this.UserDescription = UserMessage;
          this.UserDescriptionArabic =  UserArabic;
      }

      public XpremaException(string msg, int code, string other, string UserArabic, bool IsArabic)
          : base(msg)
      {
          this.XpremaMessage = msg;
          this.OtherDescription = other;
          this.CodeNumber = code;
          this.UserDescriptionArabic = UserArabic;
      }





    }
}
