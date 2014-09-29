using Xprema;
using Xprema.Helper;
public  struct Name
{
    public string FirstName{get;set;}
    public string ScondName { get; set; }
    public string LastName { get; set; }
   
    public string FullName
    {
        get
        {
            return string.Format("{0} {1} {2}", FirstName, ScondName, LastName);
        }

        set
        {
            string[] names = value.Split(' ');
            try
            {
                FirstName = names[0];
                ScondName = names[1];
                LastName = names[2];
            }
            catch (System.Exception e)
            {

                throw new XpremaException(ErrorMessageDictionary.InvalidName().Description,
                       ErrorMessageDictionary.InvalidName().CodeNumber,
                       ErrorMessageDictionary.InvalidName().OtherDescription,
                      ErrorMessageDictionary.InvalidName().UserMessage,
                        ErrorMessageDictionary.InvalidName().UserMessageArabic);
            }
        }
    }
    public string GetFullName()
    {
        
         return string.Format("{0} {1} {2}",FirstName,ScondName,LastName);
    
    }

    public static implicit operator Name (string n)
    {
        Name x = new Name();
        x.FullName = n;
        return x;
    }


}