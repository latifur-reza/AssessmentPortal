using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProblemTwoPortal.DataControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuilding _service;
        public BuildingController(IBuilding service)
        {
            _service = service;
        }

        #region List of Buildings

        // GET: api/Building
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var data = await _service.GetBuildings();
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
