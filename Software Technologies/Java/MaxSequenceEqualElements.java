import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceEqualElements {
    public static void main(String[] args) {
        int[] arr = Arrays.stream(new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        int[] numCounter = {arr[0], 1};
        int[] biggestCount = {arr[0], 1};

        for (int i = 1; i < arr.length; i++) {
            if (arr[i] == numCounter[0]) {
                numCounter[1]++;
                continue;
            }

            BiggerCounter(numCounter, biggestCount);

            numCounter[0] = arr[i];
            numCounter[1] = 1;
        }

        BiggerCounter(numCounter, biggestCount);

        for (int i = 0; i < biggestCount[1]; i++) {
            System.out.printf("%d ", biggestCount[0]);
        }
    }

    public static void BiggerCounter(int[] numCounter, int[] biggestCount) {
        if (numCounter[1] > biggestCount[1]) {
            biggestCount[0] = numCounter[0];
            biggestCount[1] = numCounter[1];
        }
    }
}
