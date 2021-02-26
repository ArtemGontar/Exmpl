using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Budget.Domain;

namespace Calculator.Controllers
{
    
    /// <summary>
    /// Calculator controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ExpendituresController : ControllerBase
    {
        public ExpendituresController()
        {
        }

        /// <summary>
        /// GET api/expenditures
        /// </summary>
        [HttpGet("")]
        public IEnumerable<Expenditure> Get()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GET api/expenditures/5
        /// </summary>
        [HttpGet("{id}")]
        public string GetById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// POST api/expenditures
        /// </summary>
        [HttpPost]
        public float Post([FromBody] string expression)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// DELETE api/expenditures/5
        /// </summary>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }
    }
}
