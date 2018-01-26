function countOccurances(key, text) {
    let count = 0;
    let indexOfKey = text.indexOf(key);

    while (indexOfKey >= 0) {
        count++;
        indexOfKey = text.indexOf(key, indexOfKey + 1);   
    }

    return count;
}

console.log(countOccurances('haha', 'hahaha'));
