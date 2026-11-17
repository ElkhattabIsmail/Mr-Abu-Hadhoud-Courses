// creating alias for System.Console
using cnsl = System.Console;

namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            // using cnsl alias instead of System.Console
            cnsl.WriteLine("Hello World!");
            cnsl.ReadKey();
        }
    }
}