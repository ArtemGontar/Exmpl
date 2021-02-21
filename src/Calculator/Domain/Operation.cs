namespace Calculator.Domain
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
}