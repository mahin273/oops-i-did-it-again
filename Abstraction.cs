using System;

abstract class DatabaseRepository<T> where T : class
{
    public abstract void Insert(T item);
    public abstract T? FindById(int id);
    public abstract void Delete(int id);

    public void InsertAll(IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            Insert(item);
        }
        Console.WriteLine("Inserted all items.");
    }
}

class UserRepository : DatabaseRepository<string>
{
    private List<(int id, string name)> _user = new();
    private int _nextId = 1;

    public override void Insert(string name)
    {
        _user.Add((_nextId++, name));
        Console.WriteLine($"Inserted user: {name}");
    }

    public override string? FindById(int id)
    {
        return _user.FirstOrDefault(u => u.id == id).name;
    }

    public override void Delete(int id)
    {
        _user.RemoveAll(u => u.id == id);
        Console.WriteLine($"Deleted user with id: {id}");
    }
}

public static class DatabaseRepositoryDemo
{
    public static void Run()
    {
        UserRepository repo = new UserRepository();
        repo.InsertAll(new[] { "Mahin", "Nasim", "Hemu" });
        Console.WriteLine(repo.FindById(2));
        repo.Delete(1);
    }
}