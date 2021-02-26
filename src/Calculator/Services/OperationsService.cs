using System.Collections.Generic;
using System.Linq;
using Calculator.Domain;
using CodingSeb.ExpressionEvaluator;

namespace Calculator.Services
{
    public interface IOperationsService
    {
        ICollection<Operation> GetOperations();
        Operation GetOperation(int id);
        float Calculate(string expression);
        void DeleteOperation(int id);
    }

    public class OperationsService : IOperationsService
    {  
        private ExpressionEvaluator expressionEvaluator;
        
        private ICollection<Operation> calculations;

        public OperationsService(){
            expressionEvaluator = new ExpressionEvaluator();
            calculations = new List<Operation>()
            {
                new Operation(1, "2+2", float.Parse(expressionEvaluator.Evaluate("2+2").ToString())),
                new Operation(2, "4+4", float.Parse(expressionEvaluator.Evaluate("4+4").ToString()))
            };
        }

        public ICollection<Operation> GetOperations()
        {
            return calculations;
        }

        public Operation GetOperation(int id)
        {
            var operation = calculations.Where(x => x.Id == id).FirstOrDefault();
            return operation;
        }

        public float Calculate(string expression)
        {
            var result = float.Parse(expressionEvaluator.Evaluate(expression).ToString());
            calculations.Add(new Operation(calculations.Count() + 1, expression, result));
            return result;
        }

        public void DeleteOperation(int id)
        {
            var operation = calculations.Where(x => x.Id == id).FirstOrDefault();
            calculations.Remove(operation);
        }
    }
}