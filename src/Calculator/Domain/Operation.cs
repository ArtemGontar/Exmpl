namespace Calculator.Domain
{
    public class Operation
    {
        public int Id {get;}
        public float? Result {get;}
        public string Expression {get;}

        public Operation(int id, string expression)
        {
            Id = id;
            Expression = expression;
        }

        public Operation(int id, string expression, float result)
        {
            Id = id;
            Expression = expression;
            Result = result;
        }

        public override string ToString() => $"{Id}: {Expression}={Result}";
    }
}