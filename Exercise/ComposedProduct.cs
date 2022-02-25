public class ComposedProduct : Product
{
    public float Discount { get; set; }
    public List<Product> Products { get; set; }

    public override decimal ValueToPay()
    {
        decimal pay = 0;
        foreach (Product product in Products)
        {
            pay += product.ValueToPay();
        }
        return pay - (pay * (decimal)Discount);
    }
    public override string ToString()
    {
        String _products = "";
        foreach (Product product in Products)
        {
            _products += $"{product.Description}, ";
        }

        return $"\n{Id} {Description}" + $"\n\tProducts...: {$"{_products}",14}" + $"\n\tDiscount......: {$"{Discount:P2}",14}" + $"\n\tValue......: {$"{ValueToPay():C2}",14}";
    }
}