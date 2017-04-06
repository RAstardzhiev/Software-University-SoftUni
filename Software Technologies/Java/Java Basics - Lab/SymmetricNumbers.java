import java.util.ArrayList;
import java.util.Scanner;

public class SymmetricNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        ArrayList<Integer> symmetricNumbers = new ArrayList<Integer>();

        int n = scanner.nextInt();

        // Adding Symmetric Numbers to the list
        for(int i = 1; i <= n; i++) {
            if (IsSymmetric("" + i)) {
                symmetricNumbers.add(i);
            }
        }

        // Printing the range of Symmetric Numbers
        for (int i = 0; i < symmetricNumbers.size(); i++) {
            System.out.printf("%d ", symmetricNumbers.get(i));
        }
    }

    private static boolean IsSymmetric(String numberAsString) {
        for (int i = 0; i <= numberAsString.length() / 2; i++) {
            if (numberAsString.charAt(i) != numberAsString.charAt(numberAsString.length() - 1 - i)) {
                return false;
            }
        }

        return true;
    }
}
