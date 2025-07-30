using System;
using System.Data;

namespace ProblemSolvingTasks
{

    public class Record
    {
        public DateTime StartTime { get; set; } //using PascalCase naming convention
        public DateTime EndTime { get; set; }
        public double PowerConsumptionRate { get; set; }

        public Record(DateTime startTime, DateTime endTime, double powerConsumptionRate)
        {
            StartTime = startTime;
            EndTime = endTime;
            PowerConsumptionRate = powerConsumptionRate;
        }

        public static double CalculateTotalCost(Record record)
        {
            //step 1: set the time for peakTime
            DateTime date = record.StartTime.Date;
            DateTime peakTime = date.AddHours(6);
            DateTime endTime = date.AddHours(22);

            //step 2: see the actual time
            DateTime current = record.StartTime;
            DateTime end = record.EndTime;

            //step 3: initialize the peak and off-peak variables
            double peakMinutes = 0;
            double offPeakMinute = 0;

            //step 4: Go minute by minute and classify the time as peak or off-peak
            while (current < end)
            {
                if (current.TimeOfDay >= peakTime.TimeOfDay && current.TimeOfDay < endTime.TimeOfDay)
                {
                    peakMinutes++;
                }
                else
                    offPeakMinute++;

                current = current.AddMinutes(1);
            }
            Console.WriteLine("Peak minutes: " + peakMinutes);
            Console.WriteLine("Off-peak minutes: " + offPeakMinute);

            double power = record.PowerConsumptionRate;
            double peakHour = peakMinutes / 60;
            double offPeakHour = offPeakMinute / 60;

            double totalCost = (0.10 * offPeakHour * power) + (0.20 * peakHour * power);
            return totalCost;
        }
            
    }

    public class Task14
    {
        public static void Run()
        {
             Console.WriteLine("\nTask 14 running: Calculating the total cost of the electricity\n");

            List<Record> records = new List<Record>
            {
                new Record(
                    new DateTime(2023, 10, 1, 5, 30, 0), //5:30
                    new DateTime(2023, 10, 1, 7, 30, 0), //7:30
                    2),
                new Record(
                    new DateTime(2023, 10, 1, 6, 30, 0), //6:30
                    new DateTime(2023, 10, 1, 7, 30, 0), //7:30
                    2)
            };

            for (int i = 0; i < records.Count; i++)
            {
                double cost = Record.CalculateTotalCost(records[i]);
                Console.WriteLine("The electricity cost for record " + (i+1) + " is: " + cost + "\n");
            }
        }
    }

}