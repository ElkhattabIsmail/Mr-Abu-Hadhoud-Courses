
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //C# 4.0 (.NET 4.5) introduced a new type called dynamic that avoids compile-time type checking. 
            //A dynamic type escapes type checking at compile-time; instead, it resolves type at run time.
            //A dynamic type variables are defined using the dynamic keyword.

            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());


   
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();
            
            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);
            
            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);
            
            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            
            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);

            //assigns default value 01/01/0001 00:00:00
            Console.WriteLine("New Date Time :");
            DateTime dt5 = new DateTime();
            dt5 = DateTime.Now;
            Console.WriteLine(dt5);

            //number of 100-nanosecond intervals that have elapsed
            //since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 

             Console.WriteLine("Tick Value :");
            //DateTime dt = new DateTime();
            Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks

           
            Console.WriteLine("\nStatic Feilds :");
            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            Console.WriteLine("currentDateTime: " + currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);



            Console.WriteLine("\n\nTime Span :");

            DateTime dt = new DateTime(2023, 2, 21);

            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(49, 25, 34);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            //this will add time span to the date.
            DateTime newDate = dt.Add(ts);

            Console.WriteLine(newDate);

            //There is five overloading constructor in TimeSpan structure

            // 1  //Default Constructor
            TimeSpan tm = new TimeSpan();

            Console.WriteLine(tm + "\n");

            // 2  //Takes Ticks As Parameter.
            TimeSpan tm2 = new TimeSpan(10);

            Console.WriteLine(tm2 + "\n");

            // 3  //Takes Hours, Minutes, Seconds  As Parameters
            TimeSpan tm3 = new TimeSpan(10, 50, 59);

            Console.WriteLine(tm3 + "\n");

            // 4 // Takes Days, Hours, Minutes, Seconds 
            TimeSpan tm4 = new TimeSpan(2, 5, 45, 55);


            Console.WriteLine(tm4 + "\n");


            // 4 // Takes Days, Hours, Minutes, Seconds,  Milliseconds
            TimeSpan tm5 = new TimeSpan(10, 22, 44, 59, 9999);

            Console.WriteLine(tm5 + "\n");


            DateTime dateTime = new DateTime(2024, 6, 14);

            Console.Write(dateTime + "\n\nAdding This Time Span    \"  ");

            TimeSpan Ts = new TimeSpan(-78, 48, 55);

            Console.WriteLine(Ts + " \" Span To The Above Date Of Day  :  \n");

            dateTime = dateTime.Add(Ts);

            Console.WriteLine("New Date   :  " + dateTime + "\n");


            Console.WriteLine("Time Spans In Negative Way  :  \n\n______________________________________________________________");
            Console.WriteLine(Ts.Days); // return int number represent a Day The result could be positive or negative
            Console.WriteLine(Ts.TotalDays); // return double Totosl Number  represent a Day With Fraction

            Console.WriteLine(Ts.Hours);     // returns int numbers Hours between -23 and 23
            Console.WriteLine(Ts.TotalHours);//returns double total milliseconds with fractiona

            Console.WriteLine(Ts.Minutes);     // returns int numbers  of Minutes between -59 and 59
            Console.WriteLine(Ts.TotalMinutes);//returns double total milliseconds with fractiona


            Console.WriteLine(Ts.Seconds);     // returns int numbers of Seconds between -59 and 59
            Console.WriteLine(Ts.TotalSeconds);//returns double total Seconds with fractiona

            Console.WriteLine(Ts.Milliseconds);      // returns int numbers of Milliseconds between -999 and 999
            Console.WriteLine(Ts.TotalMilliseconds); //returns double total Milliseconds with fractiona


            Console.WriteLine("\n______________________________________________________________\n");

            Ts = new TimeSpan(78, 48, 55);


            Console.Write(dateTime + "\n\nAdding This Time Span    \"  ");


            Console.WriteLine(Ts + " \" Span To The Above Date Of Day  :  \n");

            dateTime = dateTime.Add(Ts);

            Console.WriteLine("New Date   :  " + dateTime + "\n");


            Console.WriteLine("Time Spans In Postive Way  :  \n\n______________________________________________________________");
            Console.WriteLine(Ts.Days); // return int number represent a Day The result could be positive or negative
            Console.WriteLine(Ts.TotalDays); // return double Totosl Number  represent a Day With Fraction

            Console.WriteLine(Ts.Hours);     // returns int numbers Hours between -23 and 23
            Console.WriteLine(Ts.TotalHours);//returns double total milliseconds with fractiona

            Console.WriteLine(Ts.Minutes);     // returns int numbers  of Minutes between -59 and 59
            Console.WriteLine(Ts.TotalMinutes);//returns double total milliseconds with fractiona


            Console.WriteLine(Ts.Seconds);     // returns int numbers of Seconds between -59 and 59
            Console.WriteLine(Ts.TotalSeconds);//returns double total Seconds with fractiona

            Console.WriteLine(Ts.Milliseconds);      // returns int numbers of Milliseconds between -999 and 999
            Console.WriteLine(Ts.TotalMilliseconds); //returns double total Milliseconds with fractiona


            Console.WriteLine("\n______________________________________________________________\n");

            
            DateTime dat1 = new DateTime(2023, 2, 21);
            DateTime dat2 = new DateTime(2023, 2, 25);
            TimeSpan result = dat2.Subtract(dat1);
            Console.WriteLine("After Subtracting {0} from {1}", dat1, dat2);
            Console.WriteLine("Result = " + result.Days + " Days");


            Console.WriteLine("\n\nDates Operator :");

            DateTime date1 = new DateTime(2015, 12, 20);
            DateTime date2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(date2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(date2 - date1); //377.05:10:20
            Console.WriteLine(date1 == date2); //False
            Console.WriteLine(date1 != date2); //True
            Console.WriteLine(date1 > date2); //False
            Console.WriteLine(date1 < date2); //True
            Console.WriteLine(date1 >= date2); //False
            Console.WriteLine(date1 <= date2);//True


            //A valid date and time string can be converted to a DateTime object using Parse(), ParseExact(), 
            //TryParse() and TryParseExact() methods.
            //The Parse() and ParseExact() methods will throw an exception if the specified string is not a valid 
            //representation of a date and time.
            //So, it's recommended to use TryParse() or TryParseExact() method because they return false if 
            //a string is not valid.

            Console.WriteLine("\n try parse\n");
            var str = "6/12/2023";
            DateTime D;

            var isValidDate = DateTime.TryParse(str, out D);

            if (isValidDate)
                Console.WriteLine(D);
            else
                Console.WriteLine($"{str} is not a valid date string");

            //invalid string date
            var str2 = "6/65/2023";

            DateTime D2;

            var isValidDate2 = DateTime.TryParse(str2, out D2);

            if (isValidDate2)
                Console.WriteLine(D2);
            else
                Console.WriteLine($"{str2} is not a valid date string");
            // Or Console.WriteLine("{0} is not a valid date string",str);


            Console.WriteLine("\nString in C# : \n");

            string S1 = "Mohammed Abu-Hadhoud";

            Console.WriteLine(S1.Length);

            //this will take 5 characters staring position 2
            Console.WriteLine(S1.Substring(2, 5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3, "KKKK"));
            Console.WriteLine(S1.Replace("m", "*"));
            Console.WriteLine(S1.IndexOf("m"));
            Console.WriteLine(S1.Contains("m"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("m"));

            string S2 = "Ali,Ahmed,Khalid";

            string[] NamesList = S2.Split(',');

            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);

            string S3 = "  Abu-Hadhoud  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());

            //  String Interpolation
            Console.WriteLine("\nString Interpolation متداخلة : \n");

            string firstName = "Mohammed";
            string lastName = "Abu-Hadhoud";
            string code = "107";

            //You shold use $ to $ to identify an interpolated string 
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            Console.WriteLine(fullName);

            Console.ReadKey();


            }
        }
    }



