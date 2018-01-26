function printWordsFromText(text) {
    let pattern = /\w+/g;
    let collectedWords = [];

    let match = pattern.exec(text);
    if (match) {
        collectedWords.push(match[0])
    }

    while (match = pattern.exec(text)) {
        collectedWords.push(match[0]);
    }

    console.log(collectedWords.join('|'));
}

printWordsFromText('A Regular Expression needs to have the global flag in order to match all occurrences in the text');