using Calculator.Domain;
using Calculator.Services;
using CodingSeb.ExpressionEvaluator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public Dictionary<int, Operation> Get()
        {
            return operationsService.GetOperations();
        }

        /// <summary>
        /// GET api/calculations/5
        /// </summary>
        [HttpGet("{id}")]
        public Operation GetById(int id)
        {
            return operationsService.GetOperation(id);
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
