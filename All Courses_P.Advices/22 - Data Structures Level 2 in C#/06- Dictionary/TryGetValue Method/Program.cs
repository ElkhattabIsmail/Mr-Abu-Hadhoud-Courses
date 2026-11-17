using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating and initializing the dictionary
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 }
        };

        // Using TryGetValue
        if (fruitBasket.TryGetValue("Apple", out int appleQuantity))
        {
            Console.WriteLine($"Apple quantity: {appleQuantity}");
        }
        else
        {
            Console.WriteLine("Apple not found in the basket.");
        }

        //the following line will make exception error because orange is not there.
        // Console.WriteLine($"Orange quantity: {fruitBasket["Orange"]}");
        //class in C#. This method is essential for safely retrieving values from a dictionary,
        // avoiding exceptions that occur when trying to access keys that may not exist.
        // Using TryGetValue

//Which to Use ? (ContainsKey || TryGetValue)
//If you need both the value and to check if the key exists: Use TryGetValue. It's more efficient.
//If you just want to check if the key exists: Use ContainsKey.
        if (fruitBasket.TryGetValue("Orange", out int OrangeQuantity))
        {
            Console.WriteLine($"Orange quantity: {OrangeQuantity}");
        }
        else
        {
            Console.WriteLine("Orange not found in the basket.");
        }


        Console.ReadKey();
    }
}
