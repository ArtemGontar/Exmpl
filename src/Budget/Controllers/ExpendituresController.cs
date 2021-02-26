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
            return ;
        }

        /// <summary>
        /// GET api/expenditures/5
        /// </summary>
        [HttpGet("{id}")]
        public string GetById(int id)
        {
            return ;
        }

        /// <summary>
        /// POST api/expenditures
        /// </summary>
        [HttpPost]
        public float Post([FromBody] string expression)
        {
            return ;
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
