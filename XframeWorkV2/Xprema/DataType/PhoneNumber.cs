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
/// <summary>
/// This Type Tp Represent Phone Number Or Telephone Or Fax,
/// هذا النوع البياني لعرض  الهواتف او الفاكس او المحمول
/// </summary>
/// <seealso cref="Xprema.net" />
public struct PhoneNumber
{
    public int  CountryCode{get;set;}
    public int PhoneNumberx { get; set; }
    public PhoneNumberType PhoneType { get; set; }
    private static string _FullPhoneNumber { get; set; }

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

  public  static implicit operator PhoneNumber(string o)
  {
      PhoneNumber ph = new PhoneNumber();
      ph.SetFullNumber(o);
      return ph;
  }
      // override object.Equals
    public override bool Equals (object obj)
    {
        //       
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237  
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //

        if (obj == null || GetType() != obj.GetType()) 
        {
            return false;
        }
        
        // TODO: write your implementation of Equals() here
        throw new NotImplementedException();
        return base.Equals (obj); 
    }
    
    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
       // throw new NotImplementedException();
        return base.GetHashCode();
    }
}

