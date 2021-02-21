namespace Calculator.Domain
{
    public class Operation
    {
        private float? result;
        private string expression;

        public Operation(string expression)
        {
            this.expression = expression;
        }

        public Operation(string expression, float result)
        {
            this.expression = expression;
            this.result = result;
        }

        public override string ToString() => $"{expression}={result}";
    }
}