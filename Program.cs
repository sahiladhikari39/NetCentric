using System;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] calendarView = new int[12][]; // 12 months

            // Initialize each month with a varying number of days
            calendarView[0] = new int[31]; // January (31 days)
            calendarView[1] = new int[28]; // February (28 days, assuming non-leap year)
            calendarView[2] = new int[31]; // March (31 days)
            calendarView[3] = new int[30]; // April (30 days)
            calendarView[4] = new int[31]; // May (31 days)
            calendarView[5] = new int[30]; // June (30 days)
            calendarView[6] = new int[31]; // July (31 days)
            calendarView[7] = new int[30]; // August (30 days)
            calendarView[8] = new int[31]; // September (31 days)
            calendarView[9] = new int[30]; // October (30 days)
            calendarView[10] = new int[31]; // November (31 days)
            calendarView[11] = new int[30]; // December (30 days)

            // Ask the user to enter the year and month
            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter the month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            // Check if the month is valid
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month entered. Please enter a number between 1 and 12.");
                return;
            }

            // Ask for the first day of the month (0 = Sunday, 1 = Monday, ..., 6 = Saturday)
            Console.Write("Enter the first day of the month (0 = Sunday, 1 = Monday, ..., 6 = Saturday): ");
            int firstDay = int.Parse(Console.ReadLine());

            // Display the calendar for the chosen month
            DisplayCalendar(year, month - 1, calendarView, firstDay); // Month - 1 because months are 0-indexed in the array
        }

        // Function to display the calendar for the chosen month
        static void DisplayCalendar(int year, int month, int[][] calendarView, int firstDay)
        {
            string[] monthNames = { "January", "February", "March", "April", "May", "June",
                                    "July", "August", "September", "October", "November", "December" };

            Console.WriteLine($"\nCalendar for {monthNames[month]} {year}:");

            // Print the days of the week header
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            // Initialize a jagged array to hold the weeks for the given month
            int numDays = calendarView[month].Length;
            int numWeeks = (numDays + firstDay - 1) / 7 + 1; // Calculate how many weeks are needed

            int[][] monthCalendar = new int[numWeeks][];
            for (int i = 0; i < numWeeks; i++)
            {
                monthCalendar[i] = new int[7]; // 7 days in a week
            }

            // Fill the jagged array with days of the month
            int currentDay = 1;
            for (int week = 0; week < numWeeks; week++)
            {
                for (int dayOfWeek = 0; dayOfWeek < 7; dayOfWeek++)
                {
                    if (week == 0 && dayOfWeek < firstDay)
                    {
                        monthCalendar[week][dayOfWeek] = 0; // Empty slot before the first day of the month
                    }
                    else if (currentDay <= numDays)
                    {
                        monthCalendar[week][dayOfWeek] = currentDay++;
                    }
                    else
                    {
                        monthCalendar[week][dayOfWeek] = 0; // Empty slot after the last day of the month
                    }
                }
            }

            // Print the days in the calendar format
            foreach (var week in monthCalendar)
            {
                foreach (var day in week)
                {
                    if (day == 0)
                        Console.Write("    "); // Empty space for no day (4 spaces for alignment)
                    else
                        Console.Write($"{day,3} "); // Print the day, ensuring a 3-character width
                }
                Console.WriteLine(); // Move to the next line after each week
            }
        }
    }
}
