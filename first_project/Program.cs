using first_project.models;
using System.Transactions;

namespace first_project;
class Program
{
    static void Main()
    {
        Inventory storeInventory = new Inventory();
        Product apple = new Product("Apple", 0.5f, 100);
        storeInventory.AddProduct(apple);

        

        while (true) {

            Console.WriteLine("\n \n1. View All Products");
            Console.WriteLine("2. Search Product");
            Console.WriteLine("3. Add Product");
            Console.WriteLine("4. Remove Product");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int cho=  int.Parse (Console.ReadLine());
            
            switch (cho)
            {
                case 1: storeInventory.viewAllProduct();
                         break;
                
              
                case 2: 
                    Console.Write("Enter product name to search: ");
                    string searchName = Console.ReadLine();
                    storeInventory.searchProduct(searchName);
                    break;
                
                case 3:
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter product price: ");
                    float price = float.Parse(Console.ReadLine());

                    Console.Write("Enter product quantity: ");
                    int quantity = int.Parse(Console.ReadLine());


                    Product newProduct = new Product(name, price, quantity);
                    storeInventory.AddProduct(newProduct);
                    Console.WriteLine($"Product {name} added successfully.");
                    break;
                case 4:
                    Console.Write("Enter product name to remove: ");
                    string removeName = Console.ReadLine();
                    storeInventory.RemoveProduct(removeName);
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    return;

            }

        }
        



    }
}

