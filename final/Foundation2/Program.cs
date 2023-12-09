using System;

class Program
{
    static void Main(string[] args)
    {
        Address jacobAddress = new Address("123 bloomington drive", "Rexburg", "Idaho", "USA", true);
        Customer jacob = new Customer("Jacob Dowdle", jacobAddress);
        
        Address patricAddress = new Address ("321 Baker Street", "Toranto", "Ontario", "Canada", false);
        Customer patric = new Customer ("Partric Star", patricAddress);

        Product item1 = new Product("3D printer", "5698Y3B", 734.00, 2);
        Product item2 = new Product("Settlers of Catan", "33M2PT3", 29.99, 5);
        Product item3 = new Product("Colt 45", "99220P1", 300.50, 1);
        Product item4 = new Product("Toilet Paper 6 Pack", "44H3DC1", 10.00, 13);
        Product item5 = new Product("Flat screen TV", "00RT541", 152.99, 3);
        Product item6 = new Product("Dog Coller", "21SSE32", 3.99, 2);

        Order jacobOrder = new Order(jacob);
        jacobOrder.AddProduct(item1);
        jacobOrder.AddProduct(item3);
        jacobOrder.AddProduct(item5);

        Order patricOrder = new Order(patric);
        patricOrder.AddProduct(item2);
        patricOrder.AddProduct(item4);
        patricOrder.AddProduct(item6);

        double totalPriceJacob = Math.Round(jacobOrder.OrderTotal(), 2);
        double totalPricePatric = Math.Round(patricOrder.OrderTotal(), 2);

        jacobOrder.DisplayShippingLabel();
        jacobOrder.DisplayPackingLable();
        Console.WriteLine($"The total is {totalPriceJacob}");
        Console.WriteLine("--------------------------------");

        patricOrder.DisplayShippingLabel();
        patricOrder.DisplayPackingLable();
        Console.WriteLine($"The total is {totalPricePatric}");
    }
}