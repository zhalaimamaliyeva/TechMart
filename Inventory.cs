
public class Inventory
{
    private List<Product> products = new List<Product>();

    private Dictionary<string, Product> productsBySku =
        new Dictionary<string, Product>(
            StringComparer.OrdinalIgnoreCase
        );

    public void AddProduct(Product product)
    {
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }

        if (string.IsNullOrWhiteSpace(product.Sku))
        {
            throw new ArgumentException("SKU cannot be empty.");
        }

        string sku = product.Sku.Trim();

        if (productsBySku.ContainsKey(sku))
        {
            throw new ArgumentException(
                $"A product with SKU '{sku}' already exists."
            );
        }

        products.Add(product);
        productsBySku.Add(sku, product);
    }

public Product? GetProductById(int id)
{
    foreach (Product product in products)
    {
        if (product.Id == id)
        {
            return product;
        }
    }

    return null;
}

public Product? GetProductBySku(string? sku)
{
    if (string.IsNullOrWhiteSpace(sku))
    {
        return null;
    }

    string cleanedSku = sku.Trim();

    if (productsBySku.TryGetValue(cleanedSku, out Product? product))
    {
        return product;
    }

    return null;
}

public List<Product> SearchByName(string? searchText)
{
    List<Product> results = new List<Product>();

    if (string.IsNullOrWhiteSpace(searchText))
    {
        return results;
    }

    string cleanedText = searchText.Trim();

    foreach (Product product in products)
    {
        if (product.Name.Contains(
            cleanedText,
            StringComparison.OrdinalIgnoreCase))
        {
            results.Add(product);
        }
    }

    return results;
}

public void IncreaseStock(int id, int quantity)
{
    if (quantity <= 0)
    {
        throw new ArgumentException(
            "Quantity must be greater than zero."
        );
    }

    Product? product = GetProductById(id);

    if (product == null)
    {
        throw new ArgumentException(
            $"Product with ID {id} was not found."
        );
    }

    product.StockQuantity = checked(
        product.StockQuantity + quantity
    );
}

public void DecreaseStock(int id, int quantity)
{
    if (quantity <= 0)
    {
        throw new ArgumentException(
            "Quantity must be greater than zero."
        );
    }

    Product? product = GetProductById(id);

    if (product == null)
    {
        throw new ArgumentException(
            $"Product with ID {id} was not found."
        );
    }

    if (quantity > product.StockQuantity)
    {
        throw new InvalidOperationException(
            $"Insufficient stock. Available: {product.StockQuantity}"
        );
    }

    product.StockQuantity -= quantity;
}

public List<Product> GetLowStockProducts(int threshold)
{
    if (threshold < 0)
    {
        throw new ArgumentException(
            "Threshold cannot be negative."
        );
    }

    List<Product> lowStockProducts = new List<Product>();

    foreach (Product product in products)
    {
        if (product.StockQuantity < threshold)
        {
            lowStockProducts.Add(product);
        }
    }

    return lowStockProducts;
}

public bool RemoveProduct(int id)
{
    Product? product = GetProductById(id);

    if (product == null)
    {
        return false;
    }

    products.Remove(product);
    productsBySku.Remove(product.Sku);

    return true;
}

public List<Product> GetAllProducts()
{
    return new List<Product>(products);
}

}
