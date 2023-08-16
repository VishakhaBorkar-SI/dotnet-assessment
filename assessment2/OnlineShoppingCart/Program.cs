using System;
using System.Collections.Generic;

namespace OnlineShoppingCart
{
    class Item
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; }

        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    class ShoppingCart
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void DisplayCartContents()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("The shopping cart is empty.");
            }
            else
            {
                Console.WriteLine("Cart Contents:");
                foreach (var item in items)
                {
                    Console.WriteLine($"Item: {item.Name}, Price: {item.Price:C}, Quantity: {item.Quantity}");
                }
            }
        }

        public double TotalCost
        {
            get
            {
                double total = 0;
                foreach (var item in items)
                {
                    total += item.Price * item.Quantity;
                }
                return total;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            while (true)
            {
                Console.WriteLine("1. Add Item to Cart");
                Console.WriteLine("2. Display Cart Contents");
                Console.WriteLine("3. Calculate Total Cost");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Item Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Item Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Item Quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        Item item = new Item(name, price, quantity);
                        cart.AddItem(item);
                        Console.WriteLine("Item added to the cart.");
                        break;
                    case 2:
                        cart.DisplayCartContents();
                        break;
                    case 3:
                        double totalCost = cart.TotalCost;
                        Console.WriteLine($"Total Cost of the Cart: {totalCost:C}");
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