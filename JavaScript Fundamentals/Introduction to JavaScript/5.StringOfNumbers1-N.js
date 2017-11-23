function stringOfNumbersOneTo(number) {
    let result = [];

    for(let i = 1; i <= number; i++) {
        result[i] = i;
    }

    return result.join('');
}