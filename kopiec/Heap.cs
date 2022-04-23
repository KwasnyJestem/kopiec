using System;
using System.Collections.Generic;
using System.Text;


public enum HeapOptions { MaxHeap = -1, MinHeap = 1 } //to do wyjebania potem XD


public class Heap<T> where T : IComparable<T>
{
    private List<T> list;
    public HeapOptions Option { get; }

    // tworzy pusty kopiec dla określonego porządku
    public Heap(HeapOptions option = HeapOptions.MinHeap)
    {
        this.Option = option;
        list = new List<T>();
    }
    // ... uzupełnij kod

    public Heap(IEnumerable<T> collection, HeapOptions option = HeapOptions.MinHeap) : this(option)
    {
        foreach(var element in collection)
        {
            Insert(element);
        }
    }

    public int Count => list.Count;


    public void Insert(T x)
    {
        throw new NotImplementedException(); //ToDo
    }


    public T Delete()
    {
        throw new NotImplementedException(); //ToDo
    }


    public T Top()
    {
        return list[0]; //korekta tutaj bedzie potrzebna
    }


    public void Clear() => list.Clear();


    public T[] ToArray() => list.ToArray();

}
