import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Locale;
import java.util.Scanner;

public class CountWorkingDays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        SimpleDateFormat format = new SimpleDateFormat("dd-MM-yyyy", Locale.ENGLISH);

        Calendar startDate = DateFormatted(scanner.nextLine(), format);
        Calendar endDate = DateFormatted(scanner.nextLine(), format);

        int[][] holidays = {
                { 1, 1 },
                { 3, 3 },
                { 1, 5 },
                { 6, 5 },
                { 24, 5 },
                { 6, 9 },
                { 22, 9 },
                { 1, 11 },
                { 24, 12 },
                { 25, 12 },
                { 26, 12 }
        };

        SimpleDateFormat formatDayNumber = new SimpleDateFormat("dd", Locale.ENGLISH);
        SimpleDateFormat formatMonthNumber = new SimpleDateFormat("MM", Locale.ENGLISH);
        SimpleDateFormat formatDayOfWeek = new SimpleDateFormat("EEEE", Locale.ENGLISH);
        int workingDays = 0;
        boolean lastLoop = false;

        while (true) {
            if (lastLoop) {
                break;
            }

            if (startDate.compareTo(endDate) == 0) {
                lastLoop = true;
            }

            if (IsWorkingDay(startDate, holidays, formatDayNumber, formatMonthNumber, formatDayOfWeek)) {
                workingDays++;
            }

             startDate.add(Calendar.DATE, 1);
        }

        System.out.println(workingDays);

        /* Paarsing String to Date
        System.out.println(format.format(startDate));
         */

        /* Day Number as String
        System.out.println(formatDayNumber.format(startDate));
         */

        /* Month Number as String
        System.out.println(formatMonthNumber.format(startDate));
         */

        /* Day of week as a WORD
        System.out.println(formatDayOfWeek.format(startDate));
         */

        /* Add a day
        System.out.println(format.format(new Date(startDate.getTime() + TimeUnit.DAYS.toMillis( 1 ))));
         */
    }

    private static boolean IsWorkingDay(Calendar date, int[][] holidays, SimpleDateFormat formatDayNumber, SimpleDateFormat formatMonthNumber, SimpleDateFormat formatDayOfWeek) {
        int t = date.get(Calendar.DAY_OF_WEEK);
        if (date.get(Calendar.DAY_OF_WEEK) == 1 || date.get(Calendar.DAY_OF_WEEK) == 7) {
            return false;
        }

        for (int i = 0; i < holidays.length; i++) {
            int day = date.get(Calendar.DAY_OF_MONTH);
            int month = date.get(Calendar.MONTH);
            if (date.get(Calendar.DAY_OF_MONTH) == holidays[i][0] && date.get(Calendar.MONTH) == holidays[i][1] - 1) {
                return false;
            }
        }

        return true;
    }

    private static Calendar DateFormatted(String string, SimpleDateFormat format) {
        Calendar date = Calendar.getInstance();

        try {
            date.setTime(format.parse(string));// all done
        } catch (ParseException e) {
            e.printStackTrace();
        }

        return date;
    }
}
