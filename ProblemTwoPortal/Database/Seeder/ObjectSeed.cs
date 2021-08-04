using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Object = ProblemTwoPortal.Database.AssessmentDB.Object;

namespace ProblemTwoPortal.Database.Seeder
{
    public class ObjectSeed
    {
        public List<Object> GetObject()
        {
            var objects = new List<Object>();
            for (int i = 1; i <= 5; i++)
            {
                var data = new Object();
                data.Id = i;
                data.Name = "Object " + i;

                objects.Add(data);
            }
            return objects;
        }
    }
}
