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
    public class ObjectController : ControllerBase
    {
        private readonly IObject _service;
        public ObjectController(IObject service)
        {
            _service = service;
        }

        #region List of Objects

        // GET: api/Object
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var data = await _service.GetObjects();
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
