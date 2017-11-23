function letterOccurrencesInString(string, letter) {
    let occurances = 0;

    for (let i = 0; i < string.length; i++) {
        if(string[i] == letter) {
            occurances++;
        }
    }

    return occurances;
}