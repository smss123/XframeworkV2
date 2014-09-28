public  struct Money
{
    public string Coin;
    public double Amount;
    public string Format()
    {
        return string.Format("{0} {1}", Amount, Coin);
    }
    
}