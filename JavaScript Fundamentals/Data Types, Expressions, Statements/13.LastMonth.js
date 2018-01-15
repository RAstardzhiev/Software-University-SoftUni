function getLastDayOfPreviousMonth(params) {
    let day = params[0];
    let month = params[1];
    let year = params[2];

    let date = new Date(`${month} ${1} ${year}`);
    date.setDate(date.getDate() - 1);
    return date.getDate();
}

console.log(getLastDayOfPreviousMonth([17, 3, 2002]));
console.log(getLastDayOfPreviousMonth([13, 12, 2004]));