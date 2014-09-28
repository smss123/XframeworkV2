using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.Helper
{

  internal class ErrorMessageDictionary:XpremaBaseClass
    {
      public static readonly Helper.ErrorObj PhoneNumberInvalid = new ErrorObj();
        public ErrorMessageDictionary()
        {

        }

        public static ErrorObj InvalidPhoneNumberArea()
        {
            PhoneNumberInvalid.CodeNumber = 0;
            PhoneNumberInvalid.Description = "Error in formating";
            PhoneNumberInvalid.OtherDescription = "Phone Number Not Valid as phone Number";
            PhoneNumberInvalid.UserMessage = "Invalid Phone Number";
            PhoneNumberInvalid.UserMessageArabic = "رقم الهاتف غير صحيح";
            return PhoneNumberInvalid;
        }
        public static ErrorObj ParsingPhoneNumberArea()
        {
            PhoneNumberInvalid.CodeNumber = 1;
            PhoneNumberInvalid.Description = "Error in Parsing";
            PhoneNumberInvalid.OtherDescription = "Can't Parsing to PhoneNumber";
            PhoneNumberInvalid.UserMessage = "Error in Parsing Phone Number";
            PhoneNumberInvalid.UserMessageArabic = " لا يمكن التحويل الي رقم هاتف";
            return PhoneNumberInvalid;
        }

        public static ErrorObj InvalidName()
        {
            PhoneNumberInvalid.CodeNumber = 3;
            PhoneNumberInvalid.Description = "Error In Name";
            PhoneNumberInvalid.OtherDescription = "Can't Parsing to Name";
            PhoneNumberInvalid.UserMessage = "This Name Not Full Name Please Enter 3 Name";
            PhoneNumberInvalid.UserMessageArabic = " الاسم ناقص يرجى ادخال الاسم ثلاثي";
            return PhoneNumberInvalid;
        }

    }
}
