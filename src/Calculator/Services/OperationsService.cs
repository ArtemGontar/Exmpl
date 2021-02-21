using System.Collections.Generic;
using Calculator.Domain;
using CodingSeb.ExpressionEvaluator;

namespace Calculator.Services
{
    public interface IOperationsService
    {
        Dictionary<int, Operation> GetOperations();
        Operation GetOperation(int id);
        float Calculate(string expression);
        void DeleteOperation(int id);
    }

    public class OperationsService : IOperationsService
    {  
        private ExpressionEvaluator expressionEvaluator;
        
        private Dictionary<int, Operation> calculations;

        public OperationsService(){
            expressionEvaluator = new ExpressionEvaluator();
            calculations = new Dictionary<int, Operation>(){
                {1, new Operation("2+2", float.Parse(expressionEvaluator.Evaluate("2+2").ToString()))},
                {2, new Operation("4+4", float.Parse(expressionEvaluator.Evaluate("2+2").ToString()))}
            };
        }

        public Dictionary<int, Operation> GetOperations()
        {
            return calculations;
        }

        public Operation GetOperation(int id)
        {
            calculations.TryGetValue(id, out var operation);
            return operation;
        }

        public float Calculate(string expression)
        {
            var result = float.Parse(expressionEvaluator.Evaluate(expression).ToString());
            calculations.TryAdd(calculations.Count + 1, new Operation(expression, result));
            return result;
        }

        public void DeleteOperation(int id)
        {
            calculations.Remove(id);
        }
    }
}