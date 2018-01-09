function printBinaryLogarithm(numbers) {
    for(i = 0; i < numbers.length; i++) {
        console.log(Math.log2(numbers[i]));
    }
}

printBinaryLogarithm([7, 1, 2, 3, 5]);