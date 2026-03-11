using System;

class Product
{
    int id;
    string name;
    double price;
    double discount;

    public Product(int i, string n, double p, double d)
    {
        id = i;
        name = n;
        price = p;
        discount = d;
    }

    public double GetFinalPrice()
    {
        double finalPrice = price - (price * discount / 100);
        return finalPrice;
    }

    public void ShowDetails()
    {
        Console.WriteLine("Product Id: " + id);
        Console.WriteLine("Product Name: " + name);
        Console.WriteLine("Actual Price: " + price);
        Console.WriteLine("Discount %: " + discount);
        Console.WriteLine("Price After Discount: " + GetFinalPrice());
        Console.WriteLine();
    }
}

class Test
{
    static void Main()
    {
        Product p1 = new Product(1, "Laptop", 50000, 10);
        Product p2 = new Product(2, "Phone", 20000, 5);

        p1.ShowDetails();
        p2.ShowDetails();
    }
}