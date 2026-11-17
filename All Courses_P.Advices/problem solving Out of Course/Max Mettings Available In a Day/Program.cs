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

            // Sort meetings by EndDate in ascending order
            meetings.Sort((a, b) => a.EndDate.CompareTo(b.EndDate));

            int lastEndDate = 0;
            int numberOfMeetings = 0;

            // Iterate through the sorted meetings
            foreach (var meeting in meetings)
            {
                // If the current meeting doesn't overlap with the last scheduled meeting, schedule it
                if (meeting.StartDate >= lastEndDate)
                {
                    numberOfMeetings++;
                    lastEndDate = meeting.EndDate;
                }
            }

            return numberOfMeetings;
        }
    }
}