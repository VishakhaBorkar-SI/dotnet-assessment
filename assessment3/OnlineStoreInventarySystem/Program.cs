using System;
namespace OnlineStoreInventarySystem
{
   

    class Product
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        public Product(string productId, string name, decimal price, int quantityInStock)
        {
            ProductID = productId;
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
        }
    }

    class Electronics : Product
    {
        public string Brand { get; set; }

        public Electronics(string productId, string name, decimal price, int quantityInStock, string brand)
            : base(productId, name, price, quantityInStock)
        {
            Brand = brand;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Brand: {Brand}");
        }
    }

    class Clothing : Product
    {
        public string Size { get; set; }

        public Clothing(string productId, string name, decimal price, int quantityInStock, string size)
            : base(productId, name, price, quantityInStock)
        {
            Size = size;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Size: {Size}");
        }
    }

    class Book : Product
    {
        public string Author { get; set; }

        public Book(string productId, string name, decimal price, int quantityInStock, string author)
            : base(productId, name, price, quantityInStock)
        {
            Author = author;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Author: {Author}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Electronics electronics = new Electronics("E001", "Laptop", 800, 10, "Dell");
            Clothing clothing = new Clothing("C001", "T-Shirt", 20, 50, "Medium");
            Book book = new Book("B001", "Harry Potter and the Sorcerer's Stone", 15, 20, "J.K. Rowling");

            Console.WriteLine("Electronics Details:");
            electronics.DisplayDetails();

            Console.WriteLine("\nClothing Details:");
            clothing.DisplayDetails();

            Console.WriteLine("\nBook Details:");
            book.DisplayDetails();

            Console.ReadLine();
        }
    }

}