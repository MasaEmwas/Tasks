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

        // public static double CalculateTotalCost(Record record)
        // {
        //     //step 1: set the time for peakTime
        //     DateTime date = record.StartTime.Date;
        //     DateTime peakTime = date.AddHours(6);
        //     DateTime endTime = date.AddHours(22);

        //     //step 2: see the actual time
        //     DateTime current = record.StartTime;
        //     DateTime end = record.EndTime;


        // }
            

    }

    public class Task14
    {
        public static void Run()
        {
            List<Record> records = new List<Record>
            { 
                new Record(
                    new DateTime(2023, 10, 1, 5, 3, 0), //5:30
                    new DateTime(2023, 10, 1, 6, 3, 0), //6:30
                    0.15),
                new Record(
                    new DateTime(2023, 10, 1, 6, 3, 0), //6:30
                    new DateTime(2023, 10, 1, 7, 3, 0), //7:30
                    0.20)
            };


        }





    }

}