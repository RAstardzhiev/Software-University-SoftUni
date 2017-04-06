public class ReverseCharacters {
    public static void main(String[] args) {
        char[] input = new char[3];
        java.util.Scanner scanner = new java.util.Scanner(System.in);

        for (int i = 0; i < input.length; i++) {
            input[i] = scanner.next().charAt(0);
        }

        for (int i = input.length - 1; i >= 0; i--) {
            System.out.print(input[i]);
        }
    }
}
