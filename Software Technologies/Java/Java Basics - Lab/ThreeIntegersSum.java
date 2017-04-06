import java.util.Scanner;

public class ThreeIntegersSum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int num1 = scanner.nextInt();
        int num2 = scanner.nextInt();
        int num3 = scanner.nextInt();

        if (!CheckThreeIntegers(num1, num2, num3) &&
                !CheckThreeIntegers(num1, num3, num2) &&
                !CheckThreeIntegers(num3, num2, num1)) {
            System.out.println("No");
        }
    }

    private static boolean CheckThreeIntegers(int num1, int num2, int num3) {
        if (num1 + num2 != num3) {
            return false;
        }

        if (num1 > num2) {
            System.out.printf("%d + %d = %d\n", num2, num1, num3);
        }
        else {
            System.out.printf("%d + %d = %d\n", num1, num2, num3);
        }

        return true;
    }
}
