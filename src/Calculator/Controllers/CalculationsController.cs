using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Calculator.Controllers
{
    public class Operation
    {
        int? result;
        string expression;

        public Operation(string expression)
        {
            this.expression = expression;
        }
    }


    /// <summary>
    /// Calculator controller
    /// </summary>
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationsController : ControllerBase
    {
        private Dictionary<int, Operation> calculations;

        public CalculationsController()
        {
            calculations = new Dictionary<int, Operation>(){
                {1, new Operation("2+2")},
                {2, new Operation("4+4")}
            };
        }


        /// <summary>
        /// GET api/calculations
        /// </summary>
        [HttpGet("")]
        public Dictionary<int, Operation> Get()
        {
            return calculations;
        }

        /// <summary>
        /// GET api/calculations/5
        /// </summary>
        [HttpGet("{id}")]
        public Operation GetById(int id)
        {
            calculations.TryGetValue(id, out var operation);
            return operation;
        }

        /// <summary>
        /// POST api/calculations
        /// </summary>
        [HttpPost]
        public string Post([FromBody] string expression)
        {
            calculations.TryAdd(calculations.Count + 1, new Operation(expression));
            return String.Empty;
        }

        /// <summary>
        /// DELETE api/calculations/5
        /// </summary>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            calculations.Remove(id);
        }
    }
}
