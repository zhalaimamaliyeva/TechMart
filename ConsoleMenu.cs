
public class ConsoleMenu
{
    private readonly Inventory inventory;

    public ConsoleMenu(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("===== TECHMART MENU =====");
            Console.WriteLine("1. Show all products");
            Console.WriteLine("2. Add product");
            Console.WriteLine("3. Search product");
            Console.WriteLine("4. Increase stock");
            Console.WriteLine("5. Decrease stock");
            Console.WriteLine("6. Low stock products");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine() ?? "";

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input! Enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                {
                    Console.WriteLine("\n===== ALL PRODUCTS =====");

                    List<Product> products = inventory.GetAllProducts();

                    if (products.Count == 0)
                    {
                        Console.WriteLine("No products found.");
                    }
                    else
                    {
                        foreach (Product product in products)
                        {
                            Console.WriteLine(product);
                        }
                    }

                    break;
                }

                case 2:
                {
                    Console.WriteLine("\n===== ADD PRODUCT =====");

                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine() ?? "";

                    Console.Write("Enter SKU: ");
                    string sku = Console.ReadLine() ?? "";

                    Console.Write("Enter price: ");
                    string priceInput = Console.ReadLine() ?? "";

                    if (!decimal.TryParse(priceInput, out decimal price)
                        || price <= 0)
                    {
                        Console.WriteLine("Invalid price!");
                        break;
                    }

                    Console.Write("Enter stock quantity: ");
                    string stockInput = Console.ReadLine() ?? "";

                    if (!int.TryParse(stockInput, out int stock)
                        || stock < 0)
                    {
                        Console.WriteLine("Invalid stock quantity!");
                        break;
                    }

                    try
                    {
                        Product product = new Product(name, sku, price, stock);
                        inventory.AddProduct(product);

                        Console.WriteLine("Product added successfully!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }

                    break;
                }

                case 3:
                {
                    Console.WriteLine("\n===== SEARCH PRODUCT =====");
                    Console.WriteLine("1. Search by ID");
                    Console.WriteLine("2. Search by SKU");
                    Console.WriteLine("3. Search by Name");
                    Console.Write("Choose search type: ");

                    string searchChoice = Console.ReadLine() ?? "";

                    switch (searchChoice)
                    {
                        case "1":
                        {
                            Console.Write("Enter product ID: ");
                            string idInput = Console.ReadLine() ?? "";

                            if (!int.TryParse(idInput, out int id)
                                || id <= 0)
                            {
                                Console.WriteLine("Invalid ID!");
                                break;
                            }

                            Product? product = inventory.GetProductById(id);

                            Console.WriteLine(
                                product == null ? "Product not found." : product.ToString()
                            );

                            break;
                        }

                        case "2":
                        {
                            Console.Write("Enter SKU: ");
                            string sku = Console.ReadLine() ?? "";

                            Product? product = inventory.GetProductBySku(sku);

                            Console.WriteLine(
                                product == null ? "Product not found." : product.ToString()
                            );

                            break;
                        }

                        case "3":
                        {
                            Console.Write("Enter product name: ");
                            string name = Console.ReadLine() ?? "";

                            List<Product> results = inventory.SearchByName(name);

                            if (results.Count == 0)
                            {
                                Console.WriteLine("No matching products found.");
                            }
                            else
                            {
                                foreach (Product product in results)
                                {
                                    Console.WriteLine(product);
                                }
                            }

                            break;
                        }

                        default:
                            Console.WriteLine("Invalid search option!");
                            break;
                    }

                    break;
                }

                case 4:
                {
                    Console.WriteLine("\n===== INCREASE STOCK =====");

                    Console.Write("Enter product ID: ");
                    string idInput = Console.ReadLine() ?? "";

                    if (!int.TryParse(idInput, out int id) || id <= 0)
                    {
                        Console.WriteLine("Invalid product ID!");
                        break;
                    }

                    Console.Write("Enter quantity to add: ");
                    string quantityInput = Console.ReadLine() ?? "";

                    if (!int.TryParse(quantityInput, out int quantity)
                        || quantity <= 0)
                    {
                        Console.WriteLine("Invalid quantity!");
                        break;
                    }

                    try
                    {
                        inventory.IncreaseStock(id, quantity);
                        Console.WriteLine("Stock increased successfully!");

                        Product? product = inventory.GetProductById(id);
                        Console.WriteLine(product);
                    }
                    catch (Exception ex) when (
                        ex is ArgumentException || ex is OverflowException)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }

                    break;
                }

                case 5:
                {
                    Console.WriteLine("\n===== DECREASE STOCK =====");

                    Console.Write("Enter product ID: ");
                    string idInput = Console.ReadLine() ?? "";

                    if (!int.TryParse(idInput, out int id) || id <= 0)
                    {
                        Console.WriteLine("Invalid product ID!");
                        break;
                    }

                    Console.Write("Enter quantity to remove: ");
                    string quantityInput = Console.ReadLine() ?? "";

                    if (!int.TryParse(quantityInput, out int quantity)
                        || quantity <= 0)
                    {
                        Console.WriteLine("Invalid quantity!");
                        break;
                    }

                    try
                    {
                        inventory.DecreaseStock(id, quantity);
                        Console.WriteLine("Stock decreased successfully!");

                        Product? product = inventory.GetProductById(id);
                        Console.WriteLine(product);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }

                    break;
                }

                case 6:
                {
                    Console.WriteLine("\n===== LOW STOCK PRODUCTS =====");

                    Console.Write("Enter stock threshold: ");
                    string thresholdInput = Console.ReadLine() ?? "";

                    if (!int.TryParse(thresholdInput, out int threshold)
                        || threshold < 0)
                    {
                        Console.WriteLine("Invalid threshold!");
                        break;
                    }

                    List<Product> lowStock =
                        inventory.GetLowStockProducts(threshold);

                    if (lowStock.Count == 0)
                    {
                        Console.WriteLine("No low stock products found.");
                    }
                    else
                    {
                        foreach (Product product in lowStock)
                        {
                            Console.WriteLine(product);
                        }
                    }

                    break;
                }

                case 0:
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option! Please choose 0-6.");
                    break;
            }
        }
    }
}
