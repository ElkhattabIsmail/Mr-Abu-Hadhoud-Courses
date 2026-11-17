
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
{
    internal class Program
    {
        //Enum can have any numarical data type byte, sbyte, short,
        //ushort, int, uint, long, or ulong
        enum enWeekDays
        {
            Monday,     // 0
            Tuesday,    // 1
            Wednesday,  // 2
            Thursday,   // 3
            Friday,     // 4
            Saturday,   // 5
            Sunday      // 6
        }

        //if you set a value , it will auto number everything after it.
        enum enCategories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion         // 9
        }


        //Enum can have any numarical data type byte, sbyte, short, ushort, int, uint, long, or ulong
        //but not string

        enum enCategories2 : byte
        {
            Electronics = 1,
            Food = 5,
            Automotive = 6,
            Arts = 10,
            BeautyCare = 11,
            Fashion = 15
        }



        
        static void Main(string[] args)
        {

            //  Nullable<int> can be assigned any value
            //  from -2147483648 to 2147483647, or a null value.

            //Nullable <int> i = null;


            // enum in c#
            enWeekDays WeekDays;

            WeekDays = enWeekDays.Friday;
            Console.WriteLine(WeekDays);
            Console.WriteLine(enWeekDays.Sunday);

            WeekDays = ReadChoice();

            switch (WeekDays)
            {
                case enWeekDays.Saturday:
                    Console.WriteLine("its :" + enWeekDays.Saturday); break;

                case enWeekDays.Friday:
                    Console.WriteLine("its :" + enWeekDays.Friday); break;

                case enWeekDays.Monday:
                    Console.WriteLine("its :" + enWeekDays.Monday); break;

                case enWeekDays.Wednesday:
                    Console.WriteLine("its :" + enWeekDays.Wednesday); break;

                case enWeekDays.Thursday:
                    Console.WriteLine("its :" + enWeekDays.Thursday); break;

                case enWeekDays.Tuesday:
                    Console.WriteLine("its :" + enWeekDays.Tuesday); break;

                case enWeekDays.Sunday:
                    Console.WriteLine("its :" + enWeekDays.Sunday); break;

                default: Console.WriteLine("its :" + enWeekDays.Friday); break;


            }
            //get default value using default(type)
            int i = default(int); // 0
            float f = default(float);// 0
            decimal d = default(decimal);// 0
            bool b = default(bool);// false
            char c = default(char);// '\0'

            // C# 7.1 onwards
            //get default value using default
            int i2 = default; // 0
            float f2 = default;// 0
            decimal d2 = default;// 0
            bool b2 = default;// false
            char c2 = default;// '\0'


             enWeekDays ReadChoice()
            {
                byte Choice;
                string temp = Console.ReadLine();
                Choice = byte.Parse(temp);
                return (enWeekDays)Choice;
            }

            Console.ReadKey();

        }
    }
}


        




