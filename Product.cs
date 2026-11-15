
public class Product
{
    private static int nextId = 1;

    private int id;
    private string name = "";
    private string sku = "";
    private decimal price;
    private int stockQuantity;

    public int Id
    {
        get { return id; }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 2)
            {
                throw new ArgumentException("Product name must have at least 2 characters.");
            }

            name = value;
        }
    }

    public string Sku
    {
        get { return sku; }
        set { sku = value; }
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Price), "Price must be greater than zero.");
            }

            price = value;
        }
    }

    public int StockQuantity
    {
        get { return stockQuantity; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(StockQuantity), "Stock quantity cannot be negative.");
            }

            stockQuantity = value;
        }
    }

    public Product(string name, string sku, decimal price, int stockQuantity)
    {
        Name = name;
        Sku = sku;
        Price = price;
        StockQuantity = stockQuantity;

        id = nextId;
        nextId++;
    }
    public override string ToString()
{
    return $"ID: {Id} | Name: {Name} | SKU: {Sku} | Price: {Price} AZN | Stock: {StockQuantity}";
}
}

