namespace _03.Dependency_Inversion.Strategies
{
    using Interfaces;

    public class MultiplicationStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand) => firstOperand * secondOperand;
    }
}
