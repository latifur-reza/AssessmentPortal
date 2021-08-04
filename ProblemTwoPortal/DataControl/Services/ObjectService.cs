using ProblemTwoPortal.Database.AssessmentDB;
using ProblemTwoPortal.Database.Dto;
using ProblemTwoPortal.DataControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.DataControl.Services
{
    public class ObjectService : IObject
    {
        private readonly AssessmentDbContext _context;

        public ObjectService(AssessmentDbContext context)
        {
            _context = context;
        }

        #region List of objects
        public async Task<IEnumerable<ObjectDto>> GetObjects()
        {
            try
            {
                var data = _context.Object
                                    .OrderBy(x => x.Id)
                                    .Select(x => new ObjectDto
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
