using ProblemTwoPortal.Database.AssessmentDB;
using ProblemTwoPortal.Database.Dto;
using ProblemTwoPortal.DataControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.DataControl.Services
{
    public class BuildingService : IBuilding
    {
        private readonly AssessmentDbContext _context;

        public BuildingService(AssessmentDbContext context)
        {
            _context = context;
        }

        #region List of buildings
        public async Task<IEnumerable<BuildingDto>> GetBuildings()
        {
            try
            {
                var data = _context.Building
                                    .OrderBy(x => x.Id)
                                    .Select(x => new BuildingDto
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                        Location = x.Location,
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
