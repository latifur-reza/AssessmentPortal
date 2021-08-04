using ProblemTwoPortal.Database.AssessmentDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.Database.Seeder
{
    public class DataFieldSeed
    {
        public List<DataField> GetDataField()
        {
            var dataFields = new List<DataField>();
            for (int i = 1; i <= 5; i++)
            {
                var data = new DataField();
                data.Id = i;
                data.Name = "Data Field " + i;

                dataFields.Add(data);
            }
            return dataFields;
        }
    }
}
