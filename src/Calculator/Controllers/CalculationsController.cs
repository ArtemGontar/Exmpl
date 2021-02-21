using CodingSeb.ExpressionEvaluator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Calculator.Controllers
{
    public class Operation
    {
        float? result;
        string expression;

        public Operation(string expression)
        {
            this.expression = expression;
        }

        public Operation(string expression, float result)
        {
            this.expression = expression;
            this.result = result;
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
        private ExpressionEvaluator expressionEvaluator;
        public CalculationsController()
        {
            expressionEvaluator = new ExpressionEvaluator();
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
        public float Post([FromBody] string expression)
        {
            var result = float.Parse(expressionEvaluator.Evaluate(expression).ToString());
            calculations.TryAdd(calculations.Count + 1, new Operation(expression, result));
            return result;
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
