function printExtracteedWords(text) {
    let words = text
        .toUpperCase()
        .split(/\W+/)
        .filter(w => w !== '');
        
    console.log(words.join(', '));
}

printExtracteedWords('Hi, how are you?');
printExtracteedWords('hello');