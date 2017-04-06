import java.util.HashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class Phonebook {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        HashMap<String, String> phoneBook = new HashMap<>();

        while (true) {
            String[] command = scanner.nextLine().split("\\s");
            if (command[0].equals("END")) {
                break;
            }

            switch (command[0]) {
                case "A":
                    phoneBook.put(GetName(command, 1), command[command.length - 1]);
                    break;
                case "S":
                    String name = GetName(command, 0);
                    if (phoneBook.containsKey(name)) {
                        System.out.printf("%s -> %s\n", name, phoneBook.get(name));
                    }
                    else {
                        System.out.printf("Contact %s does not exist.\n", name);
                    }
                    break;
                case "ListAll":
                    PrintLexicographically(phoneBook);
                    break;
                    default:
                        break;
            }
        }
    }

    private static void PrintLexicographically(HashMap<String, String> phoneBook) {
        TreeMap<String, String> treeMap = new TreeMap<String, String>(phoneBook);
        for (String name : treeMap.keySet()) {
            System.out.println(name + " -> " + treeMap.get(name));
        }
    }

    private static String GetName(String[] command, int excludingLast) {
        String result = "";
        for (int i = 1; i < command.length - excludingLast; i++) {
            result += command[i] + " ";
        }

        return result.trim();
    }
}
