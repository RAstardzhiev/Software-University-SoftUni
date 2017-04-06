import java.util.Scanner;

public class URLParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String url = scanner.nextLine();

        String protocol = "";
        int protocolEndIndex = url.indexOf("://");
        if (protocolEndIndex > 0) {
            protocol = url.substring(0, url.indexOf("://"));
            url = url.substring(protocolEndIndex + 3);
        }

        String server = "";
        String resource = "";
        int serverEndIndex = url.indexOf('/');
        if (serverEndIndex < 0) {
            server = url;
        }
        else {
            server = url.substring(0, serverEndIndex);
            resource = url.substring(serverEndIndex + 1);
        }

        System.out.printf("[protocol] = \"%s\"\n", protocol);
        System.out.printf("[server] = \"%s\"\n", server);
        System.out.printf("[resource] = \"%s\"\n", resource);
    }
}
