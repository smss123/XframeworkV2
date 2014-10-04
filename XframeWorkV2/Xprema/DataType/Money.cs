public  struct XMoney
{
    public string Coin;
    public double Amount;
    public string Format()
    {
        return string.Format("{0} {1}", Amount, Coin);
    }

    public static implicit operator XMoney (string str)
    {
        try
        {
             XMoney mo = new XMoney();
            string[] ExtractValues = str.Split(' ');
             mo.Amount = double.Parse(ExtractValues[0]);
             mo.Coin = ExtractValues[1];
            return mo;
        }
        catch (System.Exception)
        {

            throw new Xprema.XpremaException("");
        }
    }
    
}