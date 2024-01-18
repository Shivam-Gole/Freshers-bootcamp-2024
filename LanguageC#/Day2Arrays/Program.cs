using System;

namespace Product
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of products to be added: ");
            int numberOfProducts = Convert.ToInt32(Console.ReadLine());

            Product[] prods = new Product[numberOfProducts];

            int choice;

            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Display All");
                Console.WriteLine("3. Find Product by ID");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < prods.Length; i++)
                        {
                            prods[i] = new Product();

                            Console.Write("Enter product id: ");
                            prods[i].ProductId = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter product name: ");
                            prods[i].ProdName = Console.ReadLine();

                            Console.Write("Enter manufacturing date (yyyy-mm-dd): ");
                            prods[i].MfgDate = DateTime.Parse(Console.ReadLine());

                            Console.Write("Enter warranty(in Months): ");
                            prods[i].Warranty = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter price: ");
                            prods[i].Price = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter stock: ");
                            prods[i].Stock = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter GST: ");
                            prods[i].Gst = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter discount: ");
                            prods[i].Discount = Convert.ToDouble(Console.ReadLine());
                        }
                        break;

                    case 2:
                        foreach (var prod in prods)
                        {
                            if (prod != null)
                                Console.WriteLine(prod.Display());
                        }
                        break;

                    case 3:
                        Console.Write("Enter the product id to find: ");
                        int findProductId = Convert.ToInt32(Console.ReadLine());

                        foreach (var prod in prods)
                        {
                            if (prod != null && prod.ProductId == findProductId)
                            {
                                Console.WriteLine(prod.Display());
                                break;
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

            } while (choice != 4);
        }
    }
}

