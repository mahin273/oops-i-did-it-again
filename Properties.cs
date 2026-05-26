using System;

public class BankAccount
{
	//Private field - Hideen from outside
	private double _balance;

	//Property- controlled access to the field
	public double Balance
	{
		get { return _balance; }
		set
		{
			if (value < 0) 
				throw new ArgumentException("Balance cannot be negative.");
			_balance = value;
        }
	}

    //Auto property - C# will generate the backing field
	public string Owner { get; set; }

    //Read-only property - only getter, no setter
	public bool IsOverdram
	{
		get { return _balance < 0; }
	}

	public BankAccount(string owner, double initialBalance)
    {
        Owner = owner;
        Balance = initialBalance; // This will use the setter, which checks for negative balance
    }
}

public static class BankDemo
{
	public static void Run()
	{
		BankAccount account = new BankAccount("Alice", 1000);
		Console.WriteLine(account.Balance);

		account.Balance = 500; // Update balance using setter
		try
		{
			account.Balance = -100; // This will throw an exception due to negative balance
		}
		catch (ArgumentException ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}
	}
}
