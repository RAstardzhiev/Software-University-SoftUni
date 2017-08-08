namespace _04.Recharge.Models
{
    using Interfaces;

    public class RechargeStation
    {
        public void Recharge(IRechargeable rechargeable)
        {
            rechargeable.Recharge();
        }
    }
}