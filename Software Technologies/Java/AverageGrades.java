import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Scanner;

public class AverageGrades {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numberOfStudents = Integer.parseInt(scanner.nextLine());
        ArrayList<Student> students = new ArrayList<Student>();

        // Setting Students[] from console input
        for (int i = 0; i < numberOfStudents; i++) {
            Student currentStudent = CreateStudent(scanner.nextLine().split("\\s"));
            students.add(currentStudent);
        }

        // Sorting Students
        Collections.sort(students, Student.StuNameComparator);

        // Printing best students
        for (Student student : students) {
            double average = student.AverageGrade();
            if (average >= 5.00) {
                System.out.printf("%s -> %1.2f\n", student.getName(), average);
            }
        }
    }

    private static Student CreateStudent(String[] studentData) {
        String name = "";
        ArrayList<Double> grades = new ArrayList<Double>();
        for (int i = 0; i < studentData.length; i++) {
            if (Character.isDigit(studentData[i].charAt(0))) {
                grades.add(Double.parseDouble(studentData[i]));
            }
            else {
                if (!name.equals("")) {
                    name += " ";
                }
                name += studentData[i];
            }
        }

        return new Student(name, grades);
    }

    public static class Student {
        private String Name;
        private ArrayList<Double> Grades;

        public double AverageGrade() {
            if (this.Grades.isEmpty()) {
                return 0;
            }

            double sum = 0;
            for (int i = 0; i < this.Grades.size(); i++) {
                sum += this.Grades.get(i);
            }

            return sum / this.Grades.size();
        }

        public Student(String name, ArrayList<Double> grades) {
            Name = name;
            Grades = grades;
        }

        public ArrayList<Double> getGrades() {
            return Grades;
        }

        public void setGrades(ArrayList<Double> grades) {
            Grades = grades;
        }

        public String getName() {
            return Name;
        }

        public void setName(String name) {
            Name = name;
        }

        public static Comparator<Student> StuNameComparator = new Comparator<Student>() {

            public int compare(Student firstStudent, Student secondStudent) {
                String name1 = firstStudent.getName();
                String name2 = secondStudent.getName();

                if (name1.equals(name2)) {
                    double average1 = firstStudent.AverageGrade();
                    double average2 = secondStudent.AverageGrade();

                    // Descending order (for Ascending - swap the return ones)
                    if (average1 < average2) return 1;
                    if (average1 > average2) return -1;
                    return 0;
                }

                // Ascending order (for Descending - return name2.compareTo(name1);)
                return name1.compareTo(name2);
            }
        };
    }
}
