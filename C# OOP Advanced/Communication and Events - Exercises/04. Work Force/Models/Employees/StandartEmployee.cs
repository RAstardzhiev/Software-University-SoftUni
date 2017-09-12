namespace _04.Work_Force.Models.Employees
{
    public class StandartEmployee : Employee
    {
        private const int WeeklyWorkingHours = 40;

        public StandartEmployee(string name) 
            : base(name, WeeklyWorkingHours)
        {
        }
    }
}
