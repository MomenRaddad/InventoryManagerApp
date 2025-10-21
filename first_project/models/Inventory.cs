namespace first_project.models

{
   class Product
   {
      private static int nextId = 1;
      internal int Id { get;}
      internal string Name { get; set; }
      internal float Price { get; set; }
      internal int Quantity { get; set; }

        public Product(string name, float price, int quantity)
      {
         Id= nextId++;
            Name = name;
         Price = price;
         Quantity = quantity;
        }
    }

    class Inventory
    {
        List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {

            products.Add(product);
        }
        
        
        public void viewAllProduct()
        {

            foreach (var item in products.Select((product, index) => new { product, index }))
            {

                Console.WriteLine($"Product:{item.index + 1}");
                // print details of product with id item.product.Id
                Console.WriteLine($"Id:{item.product.Id} Name: {item.product.Name}, Price: {item.product.Price}$, Quantity: {item.product.Quantity}");



            }
        }
        
        
        private Product FindProductByName(string name)
        {
            return products.Find(p => p.Name.ToLower() == name.ToLower());
        }
        
        
        public void searchProduct(string name)
        {
            var product = FindProductByName(name);

            if (product != null)
            {
                Console.WriteLine($"Id:{product.Id},Name: {product.Name}, Price: {product.Price}$, Quantity: {product.Quantity}");
            }
            else
            {
                Console.WriteLine($"Product {name} not found");
            }
        }
        
        
        public void RemoveProduct(string name)
        {
            var product = FindProductByName(name);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"Product {name} removed");
            }
            else
            {
                Console.WriteLine($"Product {name} not found");
            }



        }


     


    }
}
