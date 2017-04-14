namespace Calculator_CSharp.Models
{
    public class Calculator
    {
        public Calculator()
        {
            this.Result = 0;
        }

        public decimal LeftOperand { get; set; }

        public decimal RightOperand { get; set; }

        public string Operator { get; set; }

        public decimal Result { get; set; }
    }
}