using System;
//PhoneNumber Type
using Xprema;
using Xprema.Helper;
using Xprema.XExtention;
public enum PhoneNumberType
{
    Mobile,
    Telephone,
    Fax
}
//****************************************************
public struct PhoneNumber
{
    public  Nullable<int> CountryCode;
    public Nullable<int> PhoneNumberx;
    public  PhoneNumberType PhoneType;
    public string _FullPhoneNumber;

    public string GetFullPhoneNumber()
    {
       

            if (CountryCode == 0 || PhoneNumberx == 0)
            {
                throw new XpremaException("Error in formating", 0, "Phone Number Not Valid as phone Number", "Error Phone Number", "رقم الهاتف غير صحيح");
            }
            else
            {
                return _FullPhoneNumber;
            }

    }
    public void SetFullNumber(string value)
    {


            try
            {
                string Code = value.Substring(0, 3);
                int Ind = value.Length - 3;
                string phone = value.Substring(3, Ind);
                _FullPhoneNumber = Code + phone;
                PhoneNumberx = phone.ToInt();
                CountryCode = Code.ToInt();
                _FullPhoneNumber = value;
                if (CountryCode == 0 || PhoneNumberx == 0)
                {

                    throw new XpremaException(ErrorMessageDictionary.InvalidPhoneNumberArea().Description, 
                        ErrorMessageDictionary.InvalidPhoneNumberArea().CodeNumber,
                        ErrorMessageDictionary.InvalidPhoneNumberArea().OtherDescription,
                       ErrorMessageDictionary.InvalidPhoneNumberArea().UserMessage,
                         ErrorMessageDictionary.InvalidPhoneNumberArea().UserMessageArabic);
                }
            }
            catch (System.Exception e)
            {

                throw new XpremaException(ErrorMessageDictionary.ParsingPhoneNumberArea().Description,
                        ErrorMessageDictionary.ParsingPhoneNumberArea().CodeNumber,
                        ErrorMessageDictionary.ParsingPhoneNumberArea().OtherDescription,
                       ErrorMessageDictionary.ParsingPhoneNumberArea().UserMessage,
                         ErrorMessageDictionary.ParsingPhoneNumberArea().UserMessageArabic);
            }
        
    }
}

