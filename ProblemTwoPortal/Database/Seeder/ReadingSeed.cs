using ProblemTwoPortal.Database.AssessmentDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.Database.Seeder
{
    public class ReadingSeed
    {
        DateTime startTime = Convert.ToDateTime("2019-08-05 00:00:00");
        DateTime endTime = Convert.ToDateTime("2021-08-05 00:00:00");

        Random ramdom = new Random();
        public List<Reading> GetReading()
        {
            var readings = new List<Reading>();
            for (DateTime currentTime = startTime; currentTime < endTime; currentTime = currentTime.AddMinutes(1))
            {
                for (int i = 1; i <= 100; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        var data = new Reading();
                        data.BuildingId = i;
                        data.ObjectId = ramdom.Next(1, 6);  // creates a number between 1 and 5;
                        data.DataFieldId = ramdom.Next(1, 6);  // creates a number between 1 and 5;

                        var minValue = 5.00;
                        var maxValue = 50.00;
                        var next = ramdom.NextDouble();
                        data.Value = (decimal)(minValue + (next * (maxValue - minValue)));

                        data.Timestamp = currentTime;
                        readings.Add(data);
                    }
                }
                
            }
                
            return readings;
        }
    }
}
