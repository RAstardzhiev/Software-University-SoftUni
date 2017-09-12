namespace _03.Dependency_Inversion.Interfaces
{
    public interface IPrimitiveCalculator
    {
        void ChangeStrategy(IStrategy strategy);

        int PerformCalculation(int firstOperand, int secondOperand);
    }
}
