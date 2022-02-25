public class FixedPriceProduct : Product
{
    public override decimal ValueToPay()
    {
        return ((decimal)Tax * Price) + Price;
    }
    public override string ToString()
    {
        return base.ToString() + $"\n\tValue......: {$"{ValueToPay():C2}",14}";
    }
}