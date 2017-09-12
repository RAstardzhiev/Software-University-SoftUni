namespace _03.Dependency_Inversion.Models
{
    using Interfaces;
    using Strategies;

    class PrimitiveCalculator : IPrimitiveCalculator
    {
        private IStrategy calculationStrategy;

        public PrimitiveCalculator()
            : this(new AdditionStrategy())
        {
        }

        public PrimitiveCalculator(IStrategy strategy)
        {
            this.calculationStrategy = strategy;
        }

        public void ChangeStrategy(IStrategy strategy) => this.calculationStrategy = strategy;

        public int PerformCalculation(int firstOperand, int secondOperand) => this.calculationStrategy.Calculate(firstOperand, secondOperand);
    }
}
