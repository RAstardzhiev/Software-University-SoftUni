namespace _05.Security_Door
{
    using Controllers;
    using Interfaces;
    using Models;

    public class StartUp
    {
        public static void Main() 
        {
            ScannerUI scannerUi = new ScannerUI();
            IAccessProvider keyCardCheck = new KeyCardCheck(scannerUi);
            SecurityManager manager = new SecurityManager(keyCardCheck);
            manager.Check();
    }
}
}
