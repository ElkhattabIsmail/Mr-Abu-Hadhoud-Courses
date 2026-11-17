using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;


namespace CustomCollectionExample
{
    //    لإضافة جميع الـ methods والـ properties التي يجب عليك تعريفها عند وراثة interface
    //حط الماوس على اسم ال  interface
    //ودوس Alt enter
    //واختار اول خيار
    //فى ال visual studio فقط

    //    لتفيذ الواجهة بسرعة
    //Left mouse click on Interface name + Alt + Enter Than Select Implement Interface

    // ####
    //    An Enumerator is essentially a cursor or pointer that keeps track of its current position while moving through
    //    a collection of items.Think of it like your finger moving through lines of text as you read.
    //It has three key functionalities:

    //Current - tells you what item it's pointing to right now
    //MoveNext() - moves to the next item and returns true if successful, false if there are no more items
    //Reset() - goes back to the beginning of the collection

    //Here's a simple visualization:
    //var list = new List<int> { 1, 2, 3 };
    //    var enumerator = list.GetEnumerator();

    // Initially points to nothing
    // MoveNext() → points to 1 (Current = 1)
    // MoveNext() → points to 2 (Current = 2)
    // MoveNext() → points to 3 (Current = 3)
    // MoveNext() → returns false (no more items)
    public class CustomCollection<T> : IEnumerable<T> // Methods Must Impement from the User that inherits from this interface.
    {
        //  You can use any dataStructure to help u to implement these Methods 
        //  Lists, arrays, sets, HashSet, Dictionary, stack , queue.....
        private List<T> items = new List<T>();

        // M1
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {

                /*
                  yield return
                  Usage: The yield return statement is used within an iterator block to provide a value 
                   to the enumerator object and then pauses the execution of the iterator block 
                   until the next element is requested.
                  Functionality: When a yield return statement is executed, 
                   it returns the current value to the caller but remembers the current location 
                   in code for the next call. The next time the iterator is accessed, 
                   it resumes execution from the state it was left in, 
                   immediately after the last yield return statement.
                 
                 */
                yield return items[i];  // Yield ==> Store Last Item Returned.
            }
        }

        // M2
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }  // M1 And M2 Allow u to iterate over the collection.

        // Not Neccessary.
        public void Add(T item)
        {
            items.Add(item);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 10, 20, 30};
            var enumerator = list.GetEnumerator();

            foreach (var item in list)
            {

                enumerator.MoveNext();
                Console.WriteLine(enumerator.Current);

            }
            Console.ReadKey();


            var myCollection = new CustomCollection<int>();
            myCollection.Add(1);
            myCollection.Add(2);
            myCollection.Add(3);


            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }

        
            Console.ReadKey();
        }
    }
}
