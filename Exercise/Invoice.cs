namespace Exercise;
using System.Collections;
public class Invoice : Ipay
{
    private List<Product> _products = new();
    public Invoice()
    {
    }

    public decimal ValueToPay()
    {
        decimal pay = 0;
        foreach (Product product in _products)
        {
            pay += product.ValueToPay();
        }
        return pay;
    }
    public override string ToString()
    {
        String ToString = "";
        for (int i = 0; i < _products.Count; i++)
        {
            ToString += _products[i].ToString();
        }

        return $"RECEIPT" + $"\n---------------------------------------------------------" + $"\n{ToString}" + $"\n                     ================" + $"\nTOTAL: ${$"{ValueToPay():C2}",29}";
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}
