using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareStringBuilderAndNormalString
{
    internal class Program
    {
        static void  ConcatonateTextWithNormalString(int iter)
        {
            string txt = "";
            for (int i = 0; i < iter; i++)
            {
                txt += "a";
            }
            string Result = txt;
        }
        static void ConcatonateTextWithStringBuilder(int iter)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < iter; i++)
            {
                stringBuilder.Append("a");
            }
            string Result = stringBuilder.ToString();
        }
        static void Main(string[] args)
        {
            int iteration = 250000;
            Stopwatch stopwatch1 = Stopwatch.StartNew();        
            ConcatonateTextWithNormalString(iteration);
            Console.WriteLine($"String Concat Using + (Normal String) Took : {stopwatch1.ElapsedMilliseconds} ms"); //  4595 ms

            Stopwatch stopwatch2 = Stopwatch.StartNew();
            ConcatonateTextWithStringBuilder(iteration);
            Console.WriteLine($"Concat With String Builder Took : {stopwatch2.ElapsedMilliseconds} ms"); // 1 || 3 ms


            Console.ReadKey();


        }
    }
}
