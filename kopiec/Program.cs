using System;

namespace kopiec
{
    public enum HeapOptions { MaxHeap = -1, MinHeap = 1 }

    class Program
    {
        static void Main(string[] args)
        {
            // MaxHeap, tworzenie kopca
            var heap = new Heap<int>(new int[] { 2, 1, 6, 7, 1, 3 }, HeapOptions.MaxHeap);
            int[] tab = heap.ToArray();
            Console.WriteLine(string.Join(' ', tab));
            Console.WriteLine("Element szczytowy: " + heap.Top());
            Console.WriteLine("Liczba elementów: " + heap.Count);
            heap.Clear();
            Console.WriteLine("Liczba elementów po czyszczeniu: " + heap.Count);
            try
            {
                Console.WriteLine(heap.Top());
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Wyjątek przechwycony");
            }
        }
    }
}
