using ProblemTwoPortal.Database.AssessmentDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.Database.Seeder
{
    public static class SeedRegister
    {
        public static void IntializeSeedData(string connectionString)
        {
            using (var context = new AssessmentDbContext(connectionString))
            {
                var buildingSeedData = new BuildingSeed();
                context.Database.EnsureCreated();
                var building = context.Building.FirstOrDefault();
                if (building == null)
                {
                    context.Building.AddRange(buildingSeedData.GetBuilding());
                }
                context.SaveChanges();

                var objectSeedData = new ObjectSeed();
                context.Database.EnsureCreated();
                var objects = context.Object.FirstOrDefault();
                if (objects == null)
                {
                    context.Object.AddRange(objectSeedData.GetObject());
                }
                context.SaveChanges();

                var dataFieldSeedData = new DataFieldSeed();
                context.Database.EnsureCreated();
                var dataField = context.DataField.FirstOrDefault();
                if (dataField == null)
                {
                    context.DataField.AddRange(dataFieldSeedData.GetDataField());
                }
                context.SaveChanges();

                var readingSeedData = new ReadingSeed();
                context.Database.EnsureCreated();
                var readings = context.Reading.FirstOrDefault();
                if (readings == null)
                {
                    //context.Reading.AddRange(readingSeedData.GetReading());
                }
                context.SaveChanges();

            }
        }
    }
}
