namespace _03.Dependency_Inversion.Strategies
{
    using Interfaces;

    class DivisionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand) => firstOperand / secondOperand;
    }
}
