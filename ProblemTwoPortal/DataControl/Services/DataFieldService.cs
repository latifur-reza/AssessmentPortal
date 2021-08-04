using ProblemTwoPortal.Database.AssessmentDB;
using ProblemTwoPortal.Database.Dto;
using ProblemTwoPortal.DataControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.DataControl.Services
{
    public class DataFieldService : IDataField
    {
        private readonly AssessmentDbContext _context;

        public DataFieldService(AssessmentDbContext context)
        {
            _context = context;
        }

        #region List of dataFields
        public async Task<IEnumerable<DataFieldDto>> GetDataFields()
        {
            try
            {
                var data = _context.DataField
                                    .OrderBy(x => x.Id)
                                    .Select(x => new DataFieldDto
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                    });

                return await Task.FromResult(data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
