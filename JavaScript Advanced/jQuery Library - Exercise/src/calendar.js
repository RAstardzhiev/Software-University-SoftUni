function calendar(params) {
    let [day, month, year] = params;
    let inputDate = new Date(year, month - 1, day);

    let tableBody = $('<tbody>').append($('<tr>')
        .append($('<th>').text('Mon'))
        .append($('<th>').text('Tue'))
        .append($('<th>').text('Wed'))
        .append($('<th>').text('Thu'))
        .append($('<th>').text('Fri'))
        .append($('<th>').text('Sat'))
        .append($('<th>').text('Sun')));

    // First Row
    let today = inputDate.getDate();
    let firstDayOfWeek = new Date(year, month - 1, 1).getDay();
    let startAt = firstDayOfWeek === 0 ? 7 : firstDayOfWeek;    

    let currentRow = $('<tr>');
    tableBody.append(currentRow);
    let colCount = 1;
    let cellValue = 1;

    while (colCount <= 7) {
        let cell = $('<td>');
        currentRow.append(cell);

        if (startAt <= colCount) {
            cell.text(cellValue);

            if (colCount == today) {
                cell.addClass('today');
            }

            cellValue++;
        }

        colCount++;
    }

    // Appending the rest
    let lastDayInCurrentMonth = new Date(year, month, 0).getDate();
    currentRow = $('<tr>');
    tableBody.append(currentRow);
    let currentRowLength = 0;

    while (cellValue <= lastDayInCurrentMonth) {
        if (currentRowLength === 7 ) {
            currentRowLength = 0;
            currentRow = $('<tr>');
            tableBody.append(currentRow);
        }

        let cell = $('<td>').text(cellValue);
        currentRow.append(cell);

        if (today === cellValue) {
            cell.addClass('today');
        }

        cellValue++;
        currentRowLength++;
    }

    // Finish the last Row
    while (currentRowLength < 7) {
        currentRow.append($('<td>'));
        currentRowLength++;
    }

    let nameOfMonth = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"][inputDate.getMonth()];

    $('div#content')
        .append($('<table>')
            .append($('<caption>')
                .text(`${nameOfMonth} ${year}`))
            .append(tableBody));
}
