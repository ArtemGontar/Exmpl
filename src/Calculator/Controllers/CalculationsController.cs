using Calculator.Domain;
using Calculator.Services;
using CodingSeb.ExpressionEvaluator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Controllers
{
    /// <summary>
    /// Calculator controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationsController : ControllerBase
    {
        private IOperationsService operationsService;
        public CalculationsController(IOperationsService operationsService)
        {
            this.operationsService = operationsService;
        }

        /// <summary>
        /// GET api/calculations
        /// </summary>
        [HttpGet("")]
        public IEnumerable<KeyValuePair<int, string>> Get()
        {
            var f = operationsService.GetOperations().Select(x => 
                new KeyValuePair<int, string>(x.Key, x.Value.ToString()));
            Console.WriteLine(f);
            return f;
        }

        /// <summary>
        /// GET api/calculations/5
        /// </summary>
        [HttpGet("{id}")]
        public string GetById(int id)
        {
            return operationsService.GetOperation(id).ToString();
        }

        /// <summary>
        /// POST api/calculations
        /// </summary>
        [HttpPost]
        public float Post([FromBody] string expression)
        {
            return operationsService.Calculate(expression);
        }

        /// <summary>
        /// DELETE api/calculations/5
        /// </summary>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            operationsService.DeleteOperation(id);
        }
    }
}
