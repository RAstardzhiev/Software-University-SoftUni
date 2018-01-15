namespace _1.Code_First_Student_System
{
    public class Startup
    {
        public static void Main()
        {
            using (var context = new StudentSystemContext())
            {
                context.Database.Initialize(true);
                /*
                 * Next:
                 * 10.	**Photographer Roles
                 */
            }
        }
    }
}
