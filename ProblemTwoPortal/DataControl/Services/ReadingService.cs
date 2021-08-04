using ProblemTwoPortal.Database.AssessmentDB;
using ProblemTwoPortal.Database.Dto;
using ProblemTwoPortal.DataControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.DataControl.Services
{
    public class ReadingService : IReading
    {
        private readonly AssessmentDbContext _context;

        public ReadingService(AssessmentDbContext context)
        {
            _context = context;
        }

        #region List of readings
        public async Task<IEnumerable<ChartDto>> GetReadings(ReadingDto readingDto)
        {
            try
            {
                var data = _context.Reading
                                    .OrderBy(x => x.Timestamp)
                                    .Where(x => x.BuildingId.Equals(readingDto.BuildingId))
                                    .Where(x => x.ObjectId.Equals(readingDto.ObjectId))
                                    .Where(x => x.DataFieldId.Equals(readingDto.DataFieldId))
                                    .Where(x => x.Timestamp >= readingDto.StartTimestamp)
                                    .Where(x => x.Timestamp <= readingDto.EndTimestamp)
                                    .Select(x => new ChartDto
                                    {
                                        Value = x.Value,
                                        Timestamp = x.Timestamp,
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
