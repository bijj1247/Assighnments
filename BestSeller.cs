using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{

    //Mam Taking photos and uploading is a bit challenging, so i am uploading each assignment in different file but same repositor

    class Book
    {
        string Title;
        string Author;
        double Price;
        bool IsBestseller;
        public Book(string title, string author, double price, bool isBestseller)
        {
            Title = title;
            Author = author;
            Price = price;
            IsBestseller = isBestseller;
        }

        public double CalculateDiscountedPrice()
        {
            double finalPrice = Price;
            if (IsBestseller)
            {
                finalPrice = finalPrice - (finalPrice * 0.10);
            }
            if (Price > 500)
            {
                finalPrice = finalPrice - (finalPrice * 0.05);
            }
            return finalPrice;
        }

        public void Display()
        {
            double discounted_price = CalculateDiscountedPrice();              
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Original Price: " + Price);
            Console.WriteLine("Final Price: " + discounted_price);
        }
    }

    class Program
    {
        static void Main()
        {
            Book b1 = new Book("Clean Code", "Robert Martin", 600, true);

            b1.Display();
        }
    }
}
