using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Settings
        {
            public static int DayNumber
            {
                get
                {
                    return DateTime.Today.Day;
                }
            }

            public static string DayName
            {
                get
                {
                    return DateTime.Today.DayOfWeek.ToString();
                }
            }

            public static string ProjectPath
            {
                get;
                set;
            }

        }
      
        class clsA
            {
                public int PublicMemberInBaseClass = 10;
                private int PrivateMemberInBaseClass = 20;
                protected int ProtectedMemberInBaseClass = 30;

                public int Pub_fun1()
                {
                    return 100;
                }

                private int Private_fun2()
                {
                    return 200;
                }

                protected int Pro_fun1()
                {
                    return 300;
                }
            }

            class clsB : clsA
            {
                public int Pub_Fun4inClsB()
                {
                    //x1 is public and x3 is protected in the base class so you can access them.
                    //You cannot access any private members of the base class.
                    return PublicMemberInBaseClass + ProtectedMemberInBaseClass;
                }

            }
            static void Main(string[] args){

            // Read the static properties.
            //
            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine(Settings.DayName);
            //
            // Change the value of the static bool property.
            //
            Settings.ProjectPath = @"C:\MyProjects\";
            Console.WriteLine(Settings.ProjectPath);





            //Create object from class
            clsA A = new clsA();

                //all public members are accessable and internal 
                Console.WriteLine("All public members are accessable");
                Console.WriteLine("x1={0}", A.PublicMemberInBaseClass);
                Console.WriteLine("result of fun1={0}", A.Pub_fun1());

                //you cannot access private members in the folling line.
                //Console.WriteLine("x2={0}", A.x2);

                //you cannot access protected members in the folling line.
                // Console.WriteLine("x3={0}", A.x3);

                //you cannot access private members in the folling line.
                // Console.WriteLine("result of fun2={0}", A.fun2());

                //you cannot access protected members in the folling line.
                // Console.WriteLine("result of fun3={0}", A.fun3());

                clsB B = new clsB();
                Console.WriteLine("\nObjects from class B expose all public members from the base class");
                Console.WriteLine("x1={0}", B.PublicMemberInBaseClass);
                Console.WriteLine("result of fun1={0}", B.Pub_fun1());

                //you cannot access private members in the folling line.
                //Console.WriteLine("x2={0}", B.x2);
                // Console.WriteLine("result of fun1={0}", B.fun2());

                //you cannot access protected members in the folling line.
                // Console.WriteLine("x3={0}", B.x3);
                //Console.WriteLine("result of fun3={0}", B.fun3());

                Console.ReadKey();
            }
        }
    }

    

