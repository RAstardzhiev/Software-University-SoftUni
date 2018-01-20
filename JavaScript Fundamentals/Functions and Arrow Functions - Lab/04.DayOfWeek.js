function printDayOfWeek(day) {
    var number = day === 'Monday' ? 1
        : day === 'Tuesday' ? 2
        : day === 'Wednesday' ? 3
        : day === 'Thursday' ? 4
        : day === 'Friday' ? 5
        : day === 'Saturday' ? 6
        : day === 'Sunday' ? 7
        : 'error';

        console.log(number);
}

printDayOfWeek('Monday');
printDayOfWeek('Friday');
printDayOfWeek('Frabjoyousday');