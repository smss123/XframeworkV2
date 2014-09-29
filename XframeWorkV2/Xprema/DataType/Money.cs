public  struct Money
{
    public string Coin;
    public double Amount;
    public string Format()
    {
        return string.Format("{0} {1}", Amount, Coin);
    }

    public static implicit operator Money (string str)
    {
        Money mo = new Money();
        string[] ExtractValues = str.Split(' ');
        mo.Amount = double.Parse(ExtractValues[0]);
        mo.Coin = ExtractValues[1];
        return mo;
    }
    
}