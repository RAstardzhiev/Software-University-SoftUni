import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] first = scanner.nextLine().trim().split("\\s");
        String[] second = scanner.nextLine().trim().split("\\s");

        if (first[0].length() == 0 && first[0].length() == 0) {
            return;
        }
        else if (first[0].length() == 0) {
            PrintArray(second);
            return;
        }
        else if (second[0].length() == 0) {
            PrintArray(second);
            return;
        }

        boolean areEqual = false;
        boolean isFirstBigger = true;

        for (int i = 0; i < Math.min(first.length, second.length); i++) {
            if (first[i].equals(second[i])) {
                areEqual = true;
                continue;
            }

            isFirstBigger = (first[i].charAt(0) > second[i].charAt(0)) ? true : false;
            break;
        }

        if (areEqual) {
            isFirstBigger = first.length > second.length ? true : false;
        }

        if (isFirstBigger) {
            PrintArray(second);
            PrintArray(first);
        }
        else {
            PrintArray(first);
            PrintArray(second);
        }
    }

    public static void PrintArray(String[] arr) {
        for (int i = 0; i < arr.length; i++) {
            System.out.print(arr[i]);
        }

        System.out.println();
    }
}
