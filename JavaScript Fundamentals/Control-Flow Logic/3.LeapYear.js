function leapYear(year) {
    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)
        ? 'yes'
        : 'no';
}

console.log(leapYear(1900));