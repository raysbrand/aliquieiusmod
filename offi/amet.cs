using System;
using System.Collections.Generic;

public class ItemManager<T>
{
    private List<T> items;

    public ItemManager()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), "Cannot add a null item to the list.");
        }

        items.Add(item);
    }

    public bool RemoveItem(T item)
    {
        return items.Remove(item);
    }

    public int CountItems()
    {
        return items.Count;
    }

    public void DisplayItems()
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}
