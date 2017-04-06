import java.util.Scanner;

public class FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        if (input.length() >= 20) {
            System.out.println(input.substring(0, 20));
        }
        else {
            for (int i = 0; i < 20; i++) {
                if (i >= input.length()) {
                    System.out.print("*");
                    continue;
                }

                System.out.print(input.charAt(i));
            }
        }
    }
}
