import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        int[] numbers = Arrays.stream(new Scanner(System.in).nextLine().split("\\s"))
                .mapToInt(Integer::parseInt)
                .toArray();

        if (numbers.length == 1) {
            System.out.println(0);
            return;
        }

        for (int i = 0; i < numbers.length; i++) {
            int leftSum = 0, rightSum = 0;

            for (int j = 0; j < i; j++) {
                leftSum += numbers[j];
            }

            for (int j = i + 1; j < numbers.length; j++) {
                rightSum += numbers[j];
            }

            if (leftSum == rightSum) {
                System.out.println(i);
                return;
            }
        }

        System.out.println("no");
    }
}