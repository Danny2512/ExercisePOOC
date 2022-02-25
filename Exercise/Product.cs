using Exercise;
public abstract class Product : Ipay
{
    public decimal Price { get; set; }
    public int Id { get; set; }

    public string Description { get; set; }


    public double Tax { get; set; }

    public override string ToString()
    {
        return $"\n{Id} {Description}" + $"\n\tPrice......: {$"{Price:C2}",14}" + $"\n\tTax........: {$"{Tax:P2}",14}";
    }
    public abstract decimal ValueToPay();

}