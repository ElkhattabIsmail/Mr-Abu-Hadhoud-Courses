using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creating and initializing the dictionary
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };


//        ملاحظة❗
//تم استخدام الطريقة التالية لإنشاء نسخة منفصلة من البيانات:


//        var fruitInfo = fruitBasket.Select(kvp => new KeyValuePair(kvp.Key, kvp.Value));
//        بدلاً من استخدام الطريقة البسيطة:
//        var fruitInfo = fruitBasket;
//        في الطريقة الأولى، يتم إنشاء نسخة جديدة من العناصر على شكل IEnumerable < KeyValuePair >،
// وليس قاموسًا جديدًا.
//أما الطريقة الثانية فهي تُنشئ مرجعًا
// (reference)
//للقاموس الأصلي، مما يعني أن أي تعديل على fruitInfo
// سيؤثر مباشرة على fruitBasket.
        // Using LINQ to transform items
        var fruitInfo = fruitBasket.Select(kpv => new { kpv.Key, kpv.Value });

        // Displaying the results
        Console.WriteLine("Transformed Items:");
        foreach (var item in fruitInfo)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }

             // أي تعديل على fruitInfoRef
            // fruitBasket سيؤثر مباشرة على 
        var fruitInfoRef = fruitBasket;
        Console.WriteLine("Transformed Items Ref:");
        foreach (var item in fruitInfoRef)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }
        fruitInfoRef.Remove("Orange");
        // Using LINQ to filter items
        var filteredFruit = fruitBasket.Where(kpv => kpv.Value > 3);

        Console.WriteLine("\nFiltered Items >3:");
        foreach (var item in filteredFruit)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }



        // Using LINQ to sort by value
        var sortedByQuantity = fruitBasket.OrderBy(kpv => kpv.Value);

        Console.WriteLine("\nSorted Items:");
        foreach (var item in sortedByQuantity)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }

        // Using LINQ to sort by value
        var sortedByQuantityDesc = fruitBasket.OrderByDescending(kpv => kpv.Value);

        Console.WriteLine("\nSorted Items Desc:");
        foreach (var item in sortedByQuantityDesc)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }


        // Using LINQ to aggregate data
        int totalQuantity = fruitBasket.Sum(kpv => kpv.Value);

        Console.WriteLine($"\nTotal Quantity: {totalQuantity}");

        Console.ReadKey();
    }
}
