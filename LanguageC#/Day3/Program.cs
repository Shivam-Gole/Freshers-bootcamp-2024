using System;
using System.Collections.Generic;

namespace Product
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            int choice;

            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Display All");
                Console.WriteLine("3. Find Product by ID");
                Console.WriteLine("4. Remove Product by ID");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product id: ");
                        int productId = Convert.ToInt32(Console.ReadLine());

                        if (!products.ContainsKey(productId))
                        {
                            Product newProduct = new Product();

                            Console.Write("Enter product name: ");
                            newProduct.ProdName = Console.ReadLine();

                            Console.Write("Enter manufacturing date (yyyy-mm-dd): ");
                            newProduct.MfgDate = DateTime.Parse(Console.ReadLine());

                            Console.Write("Enter warranty(in months): ");
                            newProduct.Warranty = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter price: ");
                            newProduct.Price = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter stock: ");
                            newProduct.Stock = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter GST: ");
                            newProduct.Gst = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter discount: ");
                            newProduct.Discount = Convert.ToDouble(Console.ReadLine());

                            products.Add(productId, newProduct);
                        }
                        else
                        {
                            Console.WriteLine("Product with the same ID already exists. Please use a different ID.");
                        }
                        break;

                    case 2:
                        foreach (var prod in products.Values)
                        {
                            Console.WriteLine(prod.Display());
                        }
                        break;

                    case 3:
                        Console.Write("Enter product id to find: ");
                        int findProductId = Convert.ToInt32(Console.ReadLine());

                        if (products.TryGetValue(findProductId, out var foundProduct))
                        {
                            Console.WriteLine(foundProduct.Display());
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter product id to remove: ");
                        int removeProductId = Convert.ToInt32(Console.ReadLine());

                        if (products.ContainsKey(removeProductId))
                        {
                            products.Remove(removeProductId);
                            Console.WriteLine("Product removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Product not found. Removal failed.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

            } while (choice != 5);
        }
    }
}
