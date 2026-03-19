using System;

namespace Assignments
{
    class Book
    {
        private string Title;
        private string Author;
        private double Price;
        private bool IsBestseller;

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
                finalPrice -= finalPrice * 0.10;
            }
            if (finalPrice > 500)
            {
                finalPrice -= finalPrice * 0.05;
            }

            return finalPrice;
        }

        public void Display()
        {
            Console.WriteLine("======================= Details of the Book =======================");

            double discountedPrice = CalculateDiscountedPrice();

            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Original Price: " + Price);
            Console.WriteLine($"Final Price: {discountedPrice:F2}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Book b1 = new Book("The 10X Rule", "Grant Cardone", 600, true);
            Book b2 = new Book("Get Epic Shit Done", "Warikoo", 500, false);

            b1.Display();
            b2.Display();
        }
    }
}
