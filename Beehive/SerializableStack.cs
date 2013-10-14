using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[Serializable()]
public class SerializableStack<T>
{
    public List<T> data;

    public SerializableStack()
    {
        data = new List<T>();
    }

    public void Push(T d)
    {
        data.Add(d);
    }

    public T Pop()
    {
        if (data.Count == 0)
        {
            return default(T);
        }
        T result = data.ElementAt(data.Count() - 1);
        data.RemoveAt(data.Count() - 1);
        return result;
    }

    public T Peek()
    {
        if (data.Count() == 0)
        {
            return default(T);
        }
        T result = data.ElementAt(data.Count() - 1);
        return result;
    }

    public int Count()
    {
        return data.Count();
    }

    public override string ToString()
    {
        StringBuilder r = new StringBuilder();
        for (int i = data.Count() - 1; i >= 0; i--)
        {
            r.Append(data.ElementAt(i) + ", ");
        }
        return r.ToString();
    }

    public void Clear()
    {
        data.Clear();
    }

}
