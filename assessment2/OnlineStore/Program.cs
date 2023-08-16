using System;
using System.Collections.Generic;
namespace OnlineStore
{
    using System;
    using System.Collections.Generic;

    class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int QuantityInStock { get; }
        public string Category { get; }

        public Product(string name, double price, int quantityInStock, string category)
        {
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
            Category = category;
        }
    }

    class Store
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProductList()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("The store is empty. No products available.");
            }
            else
            {
                Console.WriteLine("Product List:");
                foreach (var product in products)
                {
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price:C}, Quantity in Stock: {product.QuantityInStock}, Category: {product.Category}");
                }
            }
        }

        public double CalculateTotalValueInStock()
        {
            double totalValue = 0;
            foreach (var product in products)
            {
                totalValue += product.Price * product.QuantityInStock;
            }
            return totalValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            while (true)
            {
                Console.WriteLine("1. Add Product to Store");
                Console.WriteLine("2. Display Product List");
                Console.WriteLine("3. Calculate Total Value of Products in Stock");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Product Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Product Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Quantity in Stock: ");
                        int quantityInStock = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Product Category: ");
                        string category = Console.ReadLine();

                        Product product = new Product(name, price, quantityInStock, category);
                        store.AddProduct(product);
                        Console.WriteLine("Product added to the store.");
                        break;
                    case 2:
                        store.DisplayProductList();
                        break;
                    case 3:
                        double totalValueInStock = store.CalculateTotalValueInStock();
                        Console.WriteLine($"Total Value of Products in Stock: {totalValueInStock:C}");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }

}