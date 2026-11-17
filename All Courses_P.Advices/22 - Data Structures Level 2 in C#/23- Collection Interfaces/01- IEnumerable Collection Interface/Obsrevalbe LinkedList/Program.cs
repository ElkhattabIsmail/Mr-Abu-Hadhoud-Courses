
//طبقت نفس مفهوم ال
//observable collection 
//لكن على
//linkedlist 
//مع تطبيق 
//IEnumerable Interface 
//--------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class ObservableLinkedList<T> : IEnumerable<T>
    {
        public enum OperationType { Add, Remove };

        public Action<object, OperationType> OnListChanged;

        private LinkedList<T> _linkedList;

        public ObservableLinkedList()
        {
            _linkedList = new LinkedList<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _linkedList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddItem(T item)
        {
            _linkedList.AddLast(item);
            OnListChanged?.Invoke(item, OperationType.Add);
        }

        public void RemoveItem(T item)
        {
            _linkedList.Remove(item);
            OnListChanged?.Invoke(item, OperationType.Remove);
        }
    }

    static void Main(string[] args)
    {
        var observableList = new ObservableLinkedList<string>();

        observableList.OnListChanged += HandleListChange;

        observableList.AddItem("Khalid");
        observableList.AddItem("Ahmed");
        observableList.RemoveItem("Ahmed");
        observableList.AddItem("Omar");
        observableList.AddItem("Abdulmajeed");

        var LongNames = observableList.Where(x => x.Length > 5);

        Console.WriteLine("\n\nLong Names (> 5): ");
        Console.WriteLine(string.Join(", ", LongNames));

        Console.ReadKey();
    }

    public static void HandleListChange<T>(object item, ObservableLinkedList<T>.OperationType operation)
    {
        switch (operation)
        {
            case ObservableLinkedList<T>.OperationType.Add:
                Console.WriteLine($"+++ Added: {item}");
                break;
            case ObservableLinkedList<T>.OperationType.Remove:
                Console.WriteLine($"--- Removed: {item}");
                break;
        }
    }
}