import java.util.Scanner;

public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();

        while (true) {
            int upperTagOpenIndex = text.indexOf("<upcase>");
            int upperTagCloseIndex = text.indexOf("</upcase>");

            if (upperTagCloseIndex < 0 || upperTagOpenIndex < 0) {
                break;
            }

            String textToReplace = text.substring(upperTagOpenIndex, upperTagCloseIndex + 9);

            text = text.replace(textToReplace, textToReplace.substring(8, textToReplace.length() - 9).toUpperCase());
        }

        System.out.println(text);
    }
}
