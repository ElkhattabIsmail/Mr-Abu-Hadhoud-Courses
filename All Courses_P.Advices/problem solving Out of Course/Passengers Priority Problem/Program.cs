using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Passengers_Priority_Problem
{
    class clsPassenger
    {
        public int Ticket_id { get; set; }
        public bool Is_Has_Childreen {  get; set; }

        public clsPassenger(int TicketID , bool IsHasChildreen) 
        { 
            Ticket_id = TicketID;
            Is_Has_Childreen = IsHasChildreen;
        }
        public clsPassenger Clone()
        {
            // Create a new copy of the current object
            return new clsPassenger(this.Ticket_id, this.Is_Has_Childreen);
        }

        public override string ToString()
        {
            return Ticket_id.ToString() + " | " + Is_Has_Childreen.ToString();
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<clsPassenger> PassengersList = new List<clsPassenger>
            {
                new clsPassenger(0, false),
                new clsPassenger(1, true),
                new clsPassenger(2, false),
                new clsPassenger(3, true),
                new clsPassenger(4, false),
                new clsPassenger(5, true),
                new clsPassenger(6, true),
                new clsPassenger(7, false)
            };

            List<clsPassenger> PassengersList_Cp = PassengersList.Select(p => p.Clone()).ToList();                                                           
            List<clsPassenger> PassengersList_Cp2 = PassengersList_Cp.Select(p => p.Clone()).ToList();

            PrioritizePassengers1(PassengersList);

            Console.WriteLine("\nUsing Sort Method :\n");
            foreach (var passenger in PassengersList)
            {
                Console.WriteLine(passenger);
            }

            PrioritizePassengers2(PassengersList_Cp);
            Console.WriteLine("\nSecond Method Result :\n");
            foreach (var passenger in PassengersList_Cp)
            {
                Console.WriteLine(passenger);
            }
        }

        static int Compare(clsPassenger a, clsPassenger b)
        {
            if (b.Is_Has_Childreen  == a.Is_Has_Childreen ) return 0;
            if (!b.Is_Has_Childreen && a.Is_Has_Childreen) return 1;
            return -1;
        }
        static void PrioritizePassengers1(List<clsPassenger> PassengersList)
        {
            PassengersList.Sort(Compare);
        }
        static void PrioritizePassengers2(List<clsPassenger> PassengersList)
        {
            int RightIndex = 0;

            for (int i = 0; i < PassengersList.Count ; i++)
            {
                if (!PassengersList[i].Is_Has_Childreen)
                    (PassengersList[i], PassengersList[i - RightIndex]) =
                    (PassengersList[i - RightIndex], PassengersList[i]); // "Tuple Swap"
                else
                    RightIndex++;
            }
        }

        //        new clsPassenger(0, false), RightIndex = 0       i = 0
        //        new clsPassenger(2, false), RightIndex = 1       i = 2
        //        new clsPassenger(4, false), RightIndex = 2       i = 4
        //        new clsPassenger(7, false)  RightIndex = 4       i = 7
        //        new clsPassenger(1, true),  RightIndex = 1       i = 1
        //        new clsPassenger(3, true),  RightIndex = 2       i = 3
        //        new clsPassenger(5, true),  RightIndex = 3       i = 5
        //        new clsPassenger(6, true),  RightIndex = 4       i = 6

    }
}
