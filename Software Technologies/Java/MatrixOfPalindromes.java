import java.util.Scanner;

public class MatrixOfPalindromes {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int rows = scanner.nextInt();
        int columns = scanner.nextInt();

        String[][] matrix = new String[rows][columns];

        for (int i = 0; i < matrix.length; i++) {
            char mainRowChar = (char)('a' + i);
            for (int j = 0; j < matrix[i].length; j++) {
                matrix[i][j] = "" + mainRowChar + (char)(mainRowChar + j) + mainRowChar;
            }
        }

        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                System.out.printf("%s ", matrix[i][j]);
            }
            System.out.println();
        }
    }
}
