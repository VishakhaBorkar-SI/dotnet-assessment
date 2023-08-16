using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzClubManagement
{
    internal class PerformanceManagement
    {
        int AthleteId;
        int EventId;
        ArrayList performance = new ArrayList();
        static List<PerformanceManagement> record = new List<PerformanceManagement>();
        public PerformanceManagement() { }

        public PerformanceManagement(int athleteId, int eventId, int Score, DateTime date)
        {
            this.AthleteId = athleteId;
            this.EventId = eventId;
            this.performance.Add(Score);
            this.performance.Add(date);
        }
        public void CreatePerformance(int athleteId, int eventId, int Score, DateTime date)
        {
            PerformanceManagement performance = new PerformanceManagement(athleteId, eventId, Score, date);
            record.Add(performance);
            Console.WriteLine("Performance added successfully");
        }
        public void View(int athleteId, int eventId)
        {
            foreach (PerformanceManagement performance in record)
            {
                if (performance.AthleteId == athleteId && performance.EventId == eventId)
                {
                    Console.WriteLine("Details of the Athlete's Performance");
                    Console.WriteLine($"Athlete Id : {performance.AthleteId} , Event Id : {performance.EventId} , Score : {performance.performance[0]} , Date & Time : {performance.performance[1]}");

                }


            }
            return;
            Console.WriteLine("Performance data not found ");
            return;

        }
    }
}
