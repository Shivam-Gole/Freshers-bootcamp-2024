using System;
using System.Collections.Generic;

namespace DynamicArrayNamespace
{
    public class DynamicArray<T>
    {
        private List<T> list;

        public DynamicArray(int size)
        {
            if(size > 0)
            {
                list = new List<T>();
            }
        }

        public void Add(int index, T item)
        {
            list.Insert(index, item);
        }

        public int Count => list.Count;

        public T this[int index] => list[index];
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> numbers = new DynamicArray<int> (2);
            numbers.Add(0, 100);
            numbers.Add(1, 200);
            numbers.Add(2, 300);
            numbers.Add(3, 400);
            int value = numbers[2];
            Console.WriteLine($"Total Number Of Items in Array: {numbers.Count}, Value: {value} at index: 2");

            DynamicArray<string> stringItems = new DynamicArray<string>(2);
            stringItems.Add(0, "100");
            stringItems.Add(1, "200");
            stringItems.Add(2, "300");
            stringItems.Add(3, "400");
            string itemValue = stringItems[3];
            Console.WriteLine($"Total Number Of Items in Array: {stringItems.Count}, Value: {itemValue} at index: 3");
        }
    }
}
