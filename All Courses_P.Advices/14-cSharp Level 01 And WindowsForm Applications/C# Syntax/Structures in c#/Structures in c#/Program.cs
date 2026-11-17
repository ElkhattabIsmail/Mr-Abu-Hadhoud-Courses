
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;
using System.Reflection;

namespace Main
{
//    ال structure
// هنا بتعمله زي ماكنت بتعمله في ال
// c++ 
//بس بتزود قبل المتغيرات اللي فيه كلمة
// public
//فيه فرق بسيط انك وانت بتعرف متغير من النوع
//struct
// تقدر تعرفه عادي وتقدر تقول
// = new
// وبعدها اسم ال
// struct
//الفرق بين الطريقتين انك لو ماعملتش
//new
// يبقي لازم تعين قيم لكل العناصر اللي جوه ال
// structure
// والا هيديك
// erorr
//وان كلمة
// new
// دي مش معناها هنا انك بتعمل
// pointer
// لا دي معناها انك بتستدعي ال
// default constructor
//عشان يحط القيم ال
// defaults
//بتاعت كل
// datatype
    internal class Program
    {
        struct stStudent
        {
            public string FirstName;
            public string LastName;
            public byte id;

        }

        static void Main(string[] args)
        {

            //A struct object can be created with or without the new operator,
            //same as primitive type variables.

            stStudent Student;
            stStudent Student2 = new stStudent(); // وان كلمة new 
                                                  // دي مش معناها هنا انك بتعمل
                                                  // pointer
                                                  // لا دي معناها انك بتستدعي ال
                                                  // default constructor
                                                  //عشان يحط القيم ال
                                                  // defaults
                                                  //بتاعت كل
                                                  // datatype

            Student.FirstName = "Mohammed";
            Student.LastName = "Abu-Hadhoud";
            Student.id = 20;


            Console.WriteLine(Student.FirstName);
            Console.WriteLine(Student.LastName);
            Console.WriteLine(Student.id);


            //Student2.FirstName = "Ali";
            //Student2.LastName = "Ahmed";
            //Student2.id = 15;

            Console.WriteLine(Student2.FirstName);
            Console.WriteLine(Student2.LastName);
            Console.WriteLine(Student2.id);


            Console.ReadKey();

        }
    }
}

