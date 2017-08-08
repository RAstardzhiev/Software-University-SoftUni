namespace _05.Security_Door.Models
{
    using Interfaces;

    public class PinCodeCheck : IAccessProvider
    {
        private ISecurityUI securityUI;

        public PinCodeCheck(ISecurityUI securityUI)
        {
            this.securityUI = securityUI;
        }

        private bool IsValid(int pin)
        {
            return true;
        }

        public bool ValidateUser()
        {
            int pin = this.securityUI.RequestPinCode();
            if (this.IsValid(pin))
            {
                return true;
            }

            return false;
        }
    }
}