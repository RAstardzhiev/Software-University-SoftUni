import java.util.Scanner;

public class MaxPlatform3x3 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int rows = scanner.nextInt();
        int cols = scanner.nextInt();

        long[][] matrix = new long[rows][cols];

        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                matrix[i][j] = scanner.nextLong();
            }
        }

        long maxSum = Long.MIN_VALUE;
        int maxStartRow = 0;
        int maxStartCol = 0;

        for (int i = 0; i < matrix.length - 2; i++) {
            for (int j = 0; j < matrix[i].length - 2; j++) {
                long currentSum = PlatformSum(i, j, matrix);
                if (currentSum > maxSum) {
                    maxSum = currentSum;
                    maxStartRow = i;
                    maxStartCol = j;
                }
            }
        }

        System.out.println(maxSum);
        for (int i = maxStartRow; i < maxStartRow + 3 && i < matrix.length; i++) {
            for (int j = maxStartCol; j < maxStartCol + 3 && j < matrix[i].length; j++) {
                System.out.printf("%d ", matrix[i][j]);
            }
            System.out.println();
        }
    }

    private static long PlatformSum(int row, int col, long[][] matrix) {
        long sum = 0;
        for (int i = row; i < row + 3; i++) {
            for (int j = col; j < col + 3; j++) {
                sum += matrix[i][j];
            }
        }

        return sum;
    }
}
