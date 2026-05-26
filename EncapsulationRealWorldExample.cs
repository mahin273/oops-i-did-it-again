using System;

class Product
{
    private string _name;
    private decimal _price;
    private int _stock;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name required");
            _name = value;
        }
    }

    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
                throw new ArgumentException("Price cant be negative");
            _price = value;
        }
    }

    public int Stock
    {
        get=> _stock;
        set
        {
            _stock = value;
        }
    }

    public bool InStock
    {
        get{ return _stock > 0; }
    }

    public Product(string name,decimal price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public void AddStock(int quantity)
    {
        if (quantity <= 0) throw new ArgumentException("Quantity must be pos");
        Stock += quantity;
    }

    public bool Sell(int quantity)
    {
        if (quantity > Stock)
        {
            Console.WriteLine("Not Enough stock");
            return false;
        }
        Stock-= quantity;
        return true;
    }

    public override string ToString() =>
        $"[{Name}] Price: {Price:C} | Stock: {Stock} | Available: {InStock}";

}

public static class ProductDemo
{
    public static void Run()
    {
        Product phone = new Product("Galaxy S24", 999.99m, 50);
        Console.WriteLine(phone);            // [Galaxy S24] Price: $999.99 | Stock: 50 | Available: True
        phone.Sell(5);
        phone.AddStock(10);
        Console.WriteLine(phone.Stock);
    }
}
