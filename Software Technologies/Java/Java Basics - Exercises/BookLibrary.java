import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;

public class BookLibrary {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Library library = new Library("Current Library", new ArrayList<Book>());
        SimpleDateFormat dateFormat = new SimpleDateFormat("dd.MM.yyyy");
        int inputLines = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < inputLines; i++) {
            String[] bookData = scanner.nextLine().split("\\s");
            if (bookData.length < 6) {
                System.out.println("Invalid Book. Try again!");
                continue;
            }

            // Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.
            String title = bookData[0];
            String author = bookData[1];
            String publisher = bookData[2];
            Calendar releaseDate = Calendar.getInstance();
            try {
                releaseDate.setTime(dateFormat.parse(bookData[3]));
            } catch (ParseException e) {
                System.out.println("Invalid Date. Try again!");
                continue;
            }

            String isbn = bookData[4];
            double price = Double.parseDouble(bookData[5]);

            Book currentBook = new Book(title, author, publisher, releaseDate, isbn, price);
            library.getBooks().add(currentBook);
        }

        /* Previous Exercise
        PrintByPricePerAuthor(library);
         */

        Calendar dateAfter = Calendar.getInstance();
        try {
            dateAfter.setTime(dateFormat.parse(scanner.nextLine()));
        } catch (ParseException e) {
            System.out.println("Invalid Date. Try again!");
        }

        PrintTitlesAfterDate(library, dateAfter, dateFormat);
    }

    private static void PrintTitlesAfterDate(Library library, Calendar dateAfter, SimpleDateFormat dateFormat) {
        HashMap<String, Calendar> titleDate = new HashMap<String, Calendar>();

        for (Book book : library.getBooks()) {
            if (book.getReleaseDate().compareTo(dateAfter) > 0) {
                titleDate.put(book.getTitle(), book.getReleaseDate());
            }
        }

        // Sorting by Date and then by Title lexicographically
        Map<String, Calendar> sortedTitlesByDate = new LinkedHashMap<>();
        titleDate.entrySet().stream()
                .sorted(Map.Entry.<String, Calendar>comparingByKey())
                .sorted(Map.Entry.<String, Calendar>comparingByValue())
                .forEachOrdered(b -> System.out.printf("%s -> %s\n", b.getKey(), dateFormat.format(b.getValue().getTime())));
    }

    private static void PrintByPricePerAuthor(Library library) {
        HashMap<String, Double> authorPrice = new HashMap<String, Double>();

        for (Book book : library.getBooks()) {
            String currentAuthor = book.getAuthor();
            if (!authorPrice.containsKey(currentAuthor)) {
                authorPrice.put(currentAuthor, book.getPrice());
                continue;
            }

            authorPrice.put(currentAuthor, authorPrice.get(currentAuthor) + book.getPrice());
        }

        // Sorting by Price and then by Author
        Map<String, Double> sortedAuhorsByPrice = new LinkedHashMap<>();
        authorPrice.entrySet().stream()
                .sorted(Map.Entry.<String, Double>comparingByKey())
                .sorted(Map.Entry.<String, Double>comparingByValue().reversed())
                .forEachOrdered(x -> sortedAuhorsByPrice.put(x.getKey(), x.getValue()));

        // Printing he result
        sortedAuhorsByPrice.forEach((key, val) -> System.out.printf("%s -> %1.2f\n", key, val));
    }

    public static class Library {
            private String Name;
            private ArrayList<Book> Books;

        public Library(String name, ArrayList<Book> books) {
            Name = name;
            Books = books;
        }

        public String getName() {
            return Name;
        }

        public void setName(String name) {
            Name = name;
        }

        public ArrayList<Book> getBooks() {
            return Books;
        }

        public void setBooks(ArrayList<Book> books) {
            Books = books;
        }
    }

    public static class Book {
        private String Title;
        private String Author;
        private String Publisher;
        private Calendar ReleaseDate;
        private String ISBN;
        private double Price;

        public Book(String title, String author, String publisher, Calendar releaseDate, String isbn, double price) {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            ISBN = isbn;
            Price = price;
        }

        public String getTitle() {
            return Title;
        }

        public void setTitle(String title) {
            Title = title;
        }

        public String getAuthor() {
            return Author;
        }

        public void setAuthor(String author) {
            Author = author;
        }

        public String getPublisher() {
            return Publisher;
        }

        public void setPublisher(String publisher) {
            Publisher = publisher;
        }

        public Calendar getReleaseDate() {
            return ReleaseDate;
        }

        public void setReleaseDate(Calendar releaseDate) {
            ReleaseDate = releaseDate;
        }

        public String getISBN() {
            return ISBN;
        }

        public void setISBN(String ISBN) {
            this.ISBN = ISBN;
        }

        public double getPrice() {
            return Price;
        }

        public void setPrice(double price) {
            Price = price;
        }
    }
}
