public class Order
{
    private Customer _customer;

    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CalProductCost();
        }

        if (_customer.LiveInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} \n";
            packingLabel += $"{product.GetProductId()} \n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";

        shippingLabel += $"{_customer.GetName()} \n";
        shippingLabel += $"{_customer.GetAddress().GetDisplayText()} \n";

        return shippingLabel;
    }

}