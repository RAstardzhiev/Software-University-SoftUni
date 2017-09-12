namespace _03.Dependency_Inversion.Strategies
{
    using Interfaces;

    class SubtractionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
