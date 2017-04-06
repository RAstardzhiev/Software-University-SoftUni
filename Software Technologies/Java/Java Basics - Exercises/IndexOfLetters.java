public class IndexOfLetters {
    public static void main(String[] args) {
        java.util.Scanner scanner = new java.util.Scanner(System.in);

        String input = scanner.next().toLowerCase();

        for (int i = 0; i < input.length(); i++) {
            char currentChar = input.charAt(i);
            System.out.printf("%s -> %d\n", currentChar, (int)(currentChar - 'a'));
        }
    }
}
