using LanguageDay1;
using System;

class Program
{
    static void Main()
    {
        Product product = null;
        int choice;

        do
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Exit");

            Console.Write("Select an option : ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    product = new Product();

                    Console.Write("Enter prod id: ");
                    product.ProdId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter name: ");
                    product.Name = Console.ReadLine();

                    Console.Write("Enter mfg date (yyyy-mm-dd): ");
                    product.MfgDate = DateTime.Parse(Console.ReadLine());

                    Console.Write("Enter warranty: ");
                    product.Warranty = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter price: ");
                    product.Price = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Enter stock: ");
                    product.Stock = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter GST: ");
                    product.Gst = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Enter discount: ");
                    product.Discount = Convert.ToDecimal(Console.ReadLine());

                    break;

                case 2:
                    if(product != null)
                    {
                        Console.WriteLine(product.Display());
                    }
                        
                    else
                    {
                        Console.WriteLine("No product added yet.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Exiting program.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

        } 
        while (choice != 3);
    }
}
