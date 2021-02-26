using System;

namespace Budget.Domain
{
    public class Expenditure
    {
        public ExpenditureType ExpenditureType = ExpenditureType.Other;

        public DateTime DateTime = DateTime.UtcNow;

        public float Amount;
    }
}