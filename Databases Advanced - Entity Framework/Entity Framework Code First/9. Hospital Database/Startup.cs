namespace _9.Hospital_Database
{
    public class Startup
    {
        public static void Main()
        {
            using (var context = new HospitalContext())
            {
                context.Database.Initialize(true);
            }

            // TODO: Make Console based user interface (UI) + Add login form for the doctors
        }
    }
}
