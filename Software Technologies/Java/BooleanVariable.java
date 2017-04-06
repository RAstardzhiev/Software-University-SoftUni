import java.util.Scanner;

public class BooleanVariable {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.next();

        switch (input) {
            case "True":
                System.out.println("Yes");
                break;
            case "False":
                System.out.println("No");
                break;
        }
    }
}
