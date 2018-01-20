function printModifiedAverage(number) {
    let avg = getAvg(number);
    if (avg > 5) {
        console.log(number);
    } else {
        number += '9';
        printModifiedAverage(number);
    }

    function getAvg(number) {
        number = number.toString();

        let sum = 0;
        let i = 0;
        while(i < number.length) {
            let currentNum = Number(number[i]);
            sum += currentNum;
            i++;
        }

        return sum / i;
    }
}

printModifiedAverage(101);
printModifiedAverage(5835);