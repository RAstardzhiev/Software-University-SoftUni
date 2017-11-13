namespace Hospital_Startup
{
    using P01_HospitalDatabase.Initializer;

    public class Startup
    {
        public static void Main()
        {
            DatabaseInitializer.ResetDatabase();
        }
    }
}
