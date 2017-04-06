import java.util.Scanner;

public class DiagonalDifference {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int sizeOfTheMatrix = scanner.nextInt();

        int matrix[][] = new int[sizeOfTheMatrix][sizeOfTheMatrix];

        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                matrix[i][j] = scanner.nextInt();
            }
        }

        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;

        for (int i = 0; i < matrix.length; i++){
            primaryDiagonalSum += matrix[i][i];
            secondaryDiagonalSum += matrix[i][(matrix.length - 1) - i];
        }

        System.out.println(Math.abs(primaryDiagonalSum - secondaryDiagonalSum));
    }
}
