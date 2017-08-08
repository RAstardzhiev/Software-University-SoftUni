namespace _04.Recharge.Models
{
    using Interfaces;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base(id)
        {
        }

        public void Sleep()
        {
        }
    }
}