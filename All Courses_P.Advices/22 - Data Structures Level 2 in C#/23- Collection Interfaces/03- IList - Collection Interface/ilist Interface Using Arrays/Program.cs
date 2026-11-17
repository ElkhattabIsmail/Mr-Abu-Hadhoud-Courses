using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections;
using System.Reflection;
using System.Data;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.ComponentModel;


namespace ICollectionExample
{
    public class SimpleCollectionBasedOnArray<T> : IList<T>  // IList Hight Level Interface than ICollection.
    {
        private T[] _Arr = new T[1];
        private T[] _CopyArr = new T[1];

        // IList Interface Methods.
        public T this[int index]
        {
            get => _Arr[index];
            set => _Arr[index] = value;
        }
        public int IndexOf(T item)
        {
            if (!Contains(item))
                return -1;
            return Array.IndexOf(_Arr,item);
        }
        public void Insert(int index, T item)
        {
            if (index > Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            T[] TempArr = new T[_Arr.Length + 1];
            Array.Copy(_Arr, TempArr, _Arr.Length );
            Array.Copy(TempArr, index, TempArr, index + 1, Count - index);

            TempArr[index] = item;
            _Arr = TempArr;
            _ArrayLen++;


            // OR
            //bool ItemInseted = false;

            //for (int i = 0; i < TempArr.Length - 1 ; i++)
            //{
            //    if (ItemInseted)
            //    {
            //        TempArr[i] = _Arr[i - 1];
            //    }
            //    else if (index != i)
            //    {
            //        TempArr[i] = _Arr[i];
            //    }
            //    else
            //    {
            //        TempArr[i] = item;
            //        ItemInseted = true;
            //    }
            //}
            //_Arr[index] = item;
            ////_Arr = TempArr;
            //_ArrayLen++;
        }
        public void RemoveAt(int index)
        {
            if (index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            if (!Remove(_Arr[index]))
                throw new InvalidOperationException("The element not removed from the array.");
        }

        // ICollection Interface Methods and Properties.
        public int Count => _ArrayLen;
        public bool IsReadOnly => false;

        private int _ArrayLen = 0;
        public void Add(T item)
        {
            _ArrayLen++;
            T[] TempArr = new T[_ArrayLen];

            for (int i = 0; i < _ArrayLen; i++)
            {
                TempArr[i] = _Arr[i];
            }

            TempArr[_ArrayLen - 1] = item;

            _Arr = TempArr;
            _CopyArr = new T[_ArrayLen + 1];

            for (int i = 0; i < _Arr.Length; i++) // for increasing the origin array.
            {
                _CopyArr[i] = _Arr[i];
            }
            _Arr = _CopyArr;
        }
        public void SetValueAtIndex(T item, int Index)
        {
            if (Index < Count)
            {
                _Arr.SetValue(item, Index);
            }
        }
        public void Clear()
        {
            _ArrayLen = 0;
            _Arr = new T[1];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++) // Cuz Last Items equal 0 by defaut.
            {
                if (item.Equals(_Arr[i]))
                    return true;
            }
            return false;
        }


        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(_Arr, array, arrayIndex - 1);
        }


        public bool Remove(T item)// Equals Method: The x.Equals(item) ensures proper comparison
                                  // for objects of type T. 
        {
            if (Contains(item))
            {
                _Arr = _Arr.Where(x => !x.Equals(item)).ToArray();// compare two objects.
                _ArrayLen--;
                return true;
            }

            return false;
        }


        // IEnumrable Interface (Low Level)
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _Arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            SimpleCollectionBasedOnArray<int> MyCollection = new SimpleCollectionBasedOnArray<int>();
            MyCollection.Add(1);
            MyCollection.Add(2);
            MyCollection.Add(3);

            Console.WriteLine( "Index of item 3 = " + MyCollection.IndexOf(3));
         
            MyCollection.Insert(1, 12);

            Console.WriteLine("My Collection After Iserting 12 in Index 1 : ");
            for (int i = 0; i < MyCollection.Count ; i++)
            {
                Console.WriteLine(MyCollection[i]);
            }

            MyCollection.Insert(MyCollection.Count , 20 );
            //MyCollection.Insert(MyCollection.Count + 1, 21);  // Throw Out of Rang Exception

            MyCollection.RemoveAt(0);
           /* MyCollection.RemoveAt(MyCollection.Count); */// Out of Range Exception

            Console.WriteLine($"Index of 20 Is : {MyCollection.IndexOf(20)}"); ;
            Console.WriteLine($"Index of 0 Is : {MyCollection.IndexOf(0)}"); ;


            Console.WriteLine("My Collection Items : ");
            for (int i = 0; i < MyCollection.Count; i++)
            {
                Console.WriteLine(MyCollection[i]);
            }

            Console.ReadKey();

        }
    }
}
//Input:
//  index == 1

//  itemtoAdd == 12

//  Source array (src): [1, 2, 3, 0] (length 4)

//  Destination array (des): [1, 2, 3, 0, 0] (length 5)

//  Step-by-Step Execution:
//  Create a new temporary array (TempArr) with size src.Length + 1:

//  TempArr is initialized as [0, 0, 0, 0, 0] (length 5).

//  Copy all elements from src to TempArr:

//  Array.Copy(src, TempArr, src.Length);

//  TempArr becomes [1, 2, 3, 0, 0].

//  Shift elements in TempArr to make space for the new element at index == 1:

//  Array.Copy(TempArr, 1, TempArr, 2, 3);

//  Copy 3 elements starting from index 1 ([2, 3, 0]) to index 2.

//  TempArr becomes [1, 2, 2, 3, 0].

//  Insert the new element (itemtoAdd == 12) at index == 1:

//  TempArr[1] = 12;

//  TempArr becomes [1, 12, 2, 3, 0].

//  Update the original array (src) to point to TempArr:

//  src = TempArr;

//  src is now [1, 12, 2, 3, 0].

//  Increment the length counter (_ArrayLen++):

//  The length of the array is now 5.Input:
//  index == 1

//  itemtoAdd == 12

//  Source array (src): [1, 2, 3, 0] (length 4)

//  Destination array (des): [1, 2, 3, 0, 0] (length 5)

//  Step-by-Step Execution:
//  Create a new temporary array (TempArr) with size src.Length + 1:

//  TempArr is initialized as [0, 0, 0, 0, 0] (length 5).

//  Copy all elements from src to TempArr:

//  Array.Copy(src, TempArr, src.Length);

//  TempArr becomes [1, 2, 3, 0, 0].

//  Shift elements in TempArr to make space for the new element at index == 1:

//                   index         des index  len
//  Array.Copy(TempArr, 1, TempArr,    2,      3  );

//  Copy 3 elements starting from index 1 ([2, 3, 0]) to index 2.

//  TempArr becomes [1, 2, 2, 3, 0].

//  Insert the new element (itemtoAdd == 12) at index == 1:

//  TempArr[1] = 12;

//  TempArr becomes [1, 12, 2, 3, 0].

//  Update the original array (src) to point to TempArr:

//  src = TempArr;

//  src is now [1, 12, 2, 3, 0].

//  Increment the length counter (_ArrayLen++):

//  The length of the array is now 5.



//  TempArr: The source and destination array (since we're copying within the same array).

//  index: The starting index in the source array from where to copy. // 1 - 2

//  TempArr: The destination array (same as source).

//  index + 1: The starting index in the destination array where to copy.  2 - 3 - 0 - 0

//  Count - index : The number of elements to copy.



