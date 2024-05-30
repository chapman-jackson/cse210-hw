using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Product list for order one.
        List <Product> productsListOne = new List<Product>();

        // Creating product objects and adding them to the first list.
        Product productOne = new Product("External hard drive 2TB","BTz31",89.99,2);
        productsListOne.Add(productOne);

        Product productTwo = new Product("Apple Airpods Pro","A1Px3",199.99,1);
        productsListOne.Add(productTwo);

        Product productThree = new Product("USB-C Charger cord 15FT","3nTG8",35.55,6);
        productsListOne.Add(productThree);

        // Product list for order two.
        List <Product> productsListTwo = new List<Product>();

        // Creating product objects and adding them to the second list.
        Product productFour = new Product("Dusteez compressed air","HgH25",12.99,22);
        productsListTwo.Add(productFour);

        Product productFive = new Product("Magic Mary's screen cleaner","Tg4A0",19.99,10);
        productsListTwo.Add(productFive);

        Product productSix = new Product("Ipad Pro seventh generation","Ap4X8",1050.99,3);
        productsListTwo.Add(productSix);

        // Creating customer addresses.
        Address addressOne = new Address("1234 String Avenue","Vancouver","British Columbia","Canada");
        Address addressTwo = new Address("227 Apple Way","Portland","Oregon","United States");

        // Creating customer information
        Customer customerOne = new Customer("John Doe",addressOne);
        Customer customerTwo = new Customer("Danny Smith",addressTwo);

        // Creating order objects.
        Order orderOne = new Order(customerOne,productsListOne);
        Order orderTwo = new Order(customerTwo,productsListTwo);

        // Create the shipping and product labels.
        orderOne.createShippingLabel();
        Console.WriteLine();
        orderOne.createProductLabel();
        Console.WriteLine();
        Console.WriteLine();
        orderTwo.createShippingLabel();
        Console.WriteLine();
        orderTwo.createProductLabel();
    }
}