public class VariablePriceProduct : Product
{
    public string Measurement { get; set; }
    public float Quantity { get; set; }

    public override decimal ValueToPay()
    {
        decimal priceT = (decimal)Quantity * Price;
        return (decimal)Tax * priceT + priceT;
    }
    public override string ToString()
    {
        return base.ToString() + $"\n\tMeasurment:  {Measurement}" + $"\n\tQuantity...: {$"{Quantity:C2}",14}" + $"\n\tValue......: {$"{ValueToPay():C2}",14}";
    }
}