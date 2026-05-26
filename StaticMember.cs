using System;

public class Counter
{
	private static int _totalCount = 0; //Shared across all objects
	public int Id;

	public Counter()
	{
		_totalCount++;
		Id = _totalCount;
	}

	public static int GetTotal()
	{
		return _totalCount;
	}
}




public static class CounterDemo
{
	public static void Run()
	{
		Counter c1 = new Counter();
		Counter c2 = new Counter();
		Counter c3 = new Counter();

		Console.WriteLine(Counter.GetTotal());
	}
}
