import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceIncreasingElements {
    public static void main(String[] args) {
        int[] input = Arrays.stream(new Scanner(System.in).nextLine().split("\\s"))
                .mapToInt(Integer::parseInt)
                .toArray();

        int startIndex = 0;
        int maxLength = 1;
        int counter = 1;

        for (int i = 1; i < input.length; i++) {
            if (input[i] > input[i - 1]) {
                counter++;
                continue;
            }

            if (maxLength < counter) {
                startIndex = i - counter;
                maxLength = counter;
            }

            counter = 1;
        }

        if (counter > maxLength) {
            startIndex = input.length - counter;
            maxLength = counter;
        }

        for (int i = startIndex; i < maxLength + startIndex; i++) {
            System.out.printf("%d ", input[i]);
        }
    }
}
