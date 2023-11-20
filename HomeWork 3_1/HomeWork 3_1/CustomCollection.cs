using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeWork_3_1;
public class CustomCollection<T> : IEnumerable<T>
{
    private T[] items;

    public CustomCollection()
    {
        items = new T[0];
    }

    public int Count
    {
        get { return items.Length; }
    }

    public void Sort()
    {
        Array.Sort(items);
    }

    public void Add(T item)
    {
        Array.Resize(ref items, items.Length + 1);
        items[items.Length - 1] = item;
    }

    public void SetDefaultAt(int index, T defaultValue)
    {
        if (index >= 0 && index < items.Length)
        {
            items[index] = defaultValue;
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in items)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}