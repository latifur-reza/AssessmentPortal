using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProblemTwoPortal.Database.Dto;
using ProblemTwoPortal.DataControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadingController : ControllerBase
    {
        private readonly IReading _service;
        public ReadingController(IReading service)
        {
            _service = service;
        }

        #region List of Readings

        // POST: api/Reading
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ReadingDto readingDto)
        {
            try
            {
                var data = await _service.GetReadings(readingDto);
                if (data != null && data.Count() != 0)
                {
                    return Ok(data);
                }
                return NoContent();
            }
            catch (Exception)
            {
                return NoContent();
            }
        }

        #endregion
    }
}
