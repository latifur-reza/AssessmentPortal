using ProblemTwoPortal.Database.AssessmentDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.Database.Seeder
{
    public class BuildingSeed
    {
        public List<Building> GetBuilding()
        {
            var buildings = new List<Building>();
            for (int i = 1; i <= 100; i++)
            {
                var data = new Building();
                data.Id = i;
                data.Name = "Building " + i;
                data.Location = "Location " + i;

                buildings.Add(data);
            }
            return buildings;
        }
    }
}
