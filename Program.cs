
Console.WriteLine("Welcome to TechMart!");
Console.WriteLine("--------------------");

Product product1 = new Product("iPhone 16", "IPH016", 1800m, 12);
Product product2 = new Product("Samsung S25", "SAM025", 2100m, 8);
Product product3 = new Product("MacBook Air", "MAC001", 2500m, 5);
Product product4 = new Product("AirPods Pro", "AIR002", 450m, 20);
Product product5 = new Product("iPad Air", "IPD003", 1300m,10);

Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);
Console.WriteLine(product4);
Console.WriteLine(product5);

Console.WriteLine("=== Validation tests ===");

// Test 1: Negative price
try
{
    Product invalidProduct1 = new Product("Laptop", "LAP001", -500m, 5);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Test 1 - Negative price:");
    Console.WriteLine(ex.Message);
}

// Test 2: Empty name
try
{
    Product invalidProduct2 = new Product("", "PHN001", 1000m, 3);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Test 2 - Empty name:");
    Console.WriteLine(ex.Message);
}
