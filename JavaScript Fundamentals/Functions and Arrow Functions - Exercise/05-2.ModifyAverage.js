function printModifiedAverage(number) {
    let getAvg = (numString) => numString
        .toString()
        .split('')
        .map(Number)
        .reduce((a, b) => a + b) / numString.length;

    let avg = getAvg(number);
    if (avg > 5) {
        console.log(number);
    } else {
        number += '9';
        printModifiedAverage(number);
    }
}

printModifiedAverage(101);
printModifiedAverage(5835);