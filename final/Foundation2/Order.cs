using System.Diagnostics.Contracts;
using System.Collections.Generic;
public class Order
{
    private  List<Product> _products;
    private Customer _customer;
    private int _shippingFee;


    public Order(Customer customer, List<Product> product)
    {
        _customer = customer;
        _products = product;
        _shippingFee = 0;
    }

    private int shippingCost()
    {
        if (_customer.isInUnitedStates())
        {
             _shippingFee = 5;

        }
        else
        {
            _shippingFee = 35;
        }
        return _shippingFee;
    }

    public void createShippingLabel()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine(_customer.returnCustomerInformation());
        Console.WriteLine("----------------------");
    }

    public void createProductLabel()
    {
        Console.WriteLine();
        Console.WriteLine("ITEM--ITEM_ID--PRICE--QUANTITY");
        Console.WriteLine("----------------------");
        double itemsTotal = 0;
        foreach( Product product in _products)
        {
            Console.WriteLine($"{product.returnProductInformation()}");
            itemsTotal += product.calculateItemCost();
        }
        Console.WriteLine("----------------------");
        Console.WriteLine($"Shipping fee: ${shippingCost()} Items total: ${itemsTotal}");
        double calculateTotal = itemsTotal + shippingCost();
        Console.WriteLine($"Total cost: ${calculateTotal}");
    }
}