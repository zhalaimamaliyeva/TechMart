
Console.WriteLine("Welcome to TechMart!");

Inventory inventory = new Inventory();

// Add sample products
inventory.AddProduct(new Product("iPhone 16", "IPH016", 1800m, 12));
inventory.AddProduct(new Product("Samsung S25", "SAM025", 2100m, 8));
inventory.AddProduct(new Product("MacBook Air", "MAC001", 2500m, 5));
inventory.AddProduct(new Product("AirPods Pro", "AIR002", 450m, 20));
inventory.AddProduct(new Product("iPad Air", "IPD003", 1300m, 10));
inventory.AddProduct(new Product("USB-C Adapter", "USB001", 35m, 3));
inventory.AddProduct(new Product("Charging Cable", "CBL001", 20m, 15));
inventory.AddProduct(new Product("Wireless Mouse", "MOU001", 60m, 7));
inventory.AddProduct(new Product("Keyboard", "KEY001", 90m, 4));
inventory.AddProduct(new Product("Power Bank", "PWB001", 75m, 9));

// Start console menu
ConsoleMenu menu = new ConsoleMenu(inventory);

menu.Run();
