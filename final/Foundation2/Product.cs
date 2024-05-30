public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;


    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string returnProductInformation()
    {
        return $"{_name} | {_productID} | {_price} | {_quantity}";
    }

    public double calculateItemCost()
    {
        double totalCost = 0;

        totalCost = totalCost + _price * _quantity;
        return totalCost;
    }
}
