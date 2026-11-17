using System;
using System.Collections.Generic;

namespace HashTables_Practice
{
    class ClsMetting
    {
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public override string ToString()
        {
            return $"StartDate: {StartDate}, EndDate: {EndDate}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ClsMetting> Mettings = new List<ClsMetting>
            {
                new ClsMetting { StartDate = 1, EndDate = 2 },
                new ClsMetting { StartDate = 3, EndDate = 4 },
                new ClsMetting { StartDate = 0, EndDate = 6 },
                new ClsMetting { StartDate = 5, EndDate = 7 },
                new ClsMetting { StartDate = 5, EndDate = 9 },
                new ClsMetting { StartDate = 8, EndDate = 9 }
            };

            Console.WriteLine($"Max Available Meetings = {MaxAvailableMeetings(Mettings)}");
        }

        static int MaxAvailableMeetings(List<ClsMetting> meetings)
        {
            // Edge case: If the list is empty, return 0
            if (meetings == null || meetings.Count == 0)
                return 0;

            // Sort meetings by StartDate in ascending order
            meetings.Sort((a, b) => a.StartDate.CompareTo(b.StartDate));

            // Min-heap to track end times of scheduled meetings
            var minHeap = new SortedSet<int>();

            foreach (var meeting in meetings)
            {
                // If the current meeting can be scheduled without overlapping
                if (minHeap.Count == 0 || meeting.StartDate >= minHeap.Min)
                {
                    // Add the current meeting's end time to the heap
                    minHeap.Add(meeting.EndDate);
                }
                else
                {
                    // If the current meeting overlaps with the earliest-ending meeting,
                    // remove the earliest-ending meeting and add the current meeting
                    minHeap.Remove(minHeap.Min);
                    minHeap.Add(meeting.EndDate);
                }
            }

            // The size of the heap is the maximum number of non-overlapping meetings
            return minHeap.Count;
        }
    }
}