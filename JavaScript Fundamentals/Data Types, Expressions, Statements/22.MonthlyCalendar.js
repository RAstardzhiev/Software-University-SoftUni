function calendar(params) {
    let day = params[0];
    let month = params[1];
    let year = params[2];
    let date = new Date(year, month - 1, day);
    let firstDayInCurrentMonth = new Date(year, month - 1, 1).getDay();
    let previousMonthLastDay = new Date(year, month - 1, 0).getDate();

    let result = '<table>\r\n  <tr><th>Sun</th><th>Mon</th><th>Tue</th><th>Wed</th><th>Thu</th><th>Fri</th><th>Sat</th></tr>\r\n  <tr>';

    // Add Previous Month
    let prevMonthStartValue = previousMonthLastDay - firstDayInCurrentMonth + 1;
    for (let i = prevMonthStartValue; i <= previousMonthLastDay; i++) {
        result += `<td class="prev-month">${i}</td>`;
    }

    let currentValue = 1;

    // Current month - Finish first row
    for (let i = firstDayInCurrentMonth; i <= 6; i++) {
        if (currentValue == day) {
            result += `<td class="today">${currentValue++}</td>`;
        } else {
            result += `<td>${currentValue++}</td>`;
        }
    }

    // Current month - print the rest
    let currentMonthLastDay = new Date(year, month, 0).getDate();
    let rowCount = 0;
    while (currentValue <= currentMonthLastDay) {
        if (rowCount++ % 7 == 0) {
            result += '</tr>\r\n  <tr>'
        }

        if (currentValue == day) {
            result += `<td class="today">${currentValue++}</td>`;
        } else {
            result += `<td>${currentValue++}</td>`;
        }
    }

    // Next month - finish the row
    currentValue = 1;
    while (rowCount++ % 7 != 0) {
        result += `<td class="next-month">${currentValue++}</td>`;
    }

    result += '</tr>\r\n</table>';
    return result;
}

console.log(calendar([24, 12, 2012]));
console.log();
console.log();
console.log(calendar([4, 9, 2016]));