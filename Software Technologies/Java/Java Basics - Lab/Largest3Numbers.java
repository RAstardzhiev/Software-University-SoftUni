import java.util.Arrays;
        import java.util.Scanner;

public class Largest3Numbers {
    public static void main(String[] args) {
        int[] numbers = Arrays
                .stream(new Scanner(System.in).nextLine().split("\\s"))
                .mapToInt(Integer::parseInt)
                .toArray();

        Arrays.sort(numbers);

        for (int i = 0; i < 3 && i < numbers.length; i++) {
            System.out.print(numbers[numbers.length - 1 - i] + " ");
        }
    }
}
