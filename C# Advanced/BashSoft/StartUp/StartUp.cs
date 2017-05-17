namespace StartUp
{
    using Library;

    public class StartUp
    {
        public static void Main()
        {
            StudentsRepository.InitializeData();
            StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");
        }
    }
}
