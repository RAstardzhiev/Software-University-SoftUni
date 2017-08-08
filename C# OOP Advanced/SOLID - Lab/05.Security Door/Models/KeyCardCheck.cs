namespace _05.Security_Door.Models
{
    using Interfaces;

    public class KeyCardCheck : IAccessProvider
    {
        private ISecurityUI securityUI;

        public KeyCardCheck(ISecurityUI securityUI)
        {
            this.securityUI = securityUI;
        }

        private bool IsValid(string code)
        {
            return true;
        }

        public bool ValidateUser()
        {
            string code = this.securityUI.RequestKeyCard();
            if (this.IsValid(code))
            {
                return true;
            }

            return false;
        }
    }
}