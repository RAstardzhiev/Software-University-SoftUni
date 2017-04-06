import java.util.Scanner;
import java.util.TreeMap;

public class SumsByTown {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeMap<String, Double> townSums = new TreeMap<>();
        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            String[] input = scanner.nextLine().split("\\|");
            String town = input[0].trim();
            double money = Double.parseDouble(input[1].trim());

            if (townSums.containsKey(town)) {
                townSums.put(town, townSums.get(town) + money);
            }
            else {
                townSums.put(town, money);
            }
        }

        for (String key : townSums.keySet()) {
            System.out.println(key + " -> " + townSums.get(key));
        }
    }
}
