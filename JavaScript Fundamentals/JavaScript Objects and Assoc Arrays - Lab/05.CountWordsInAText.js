function countWords(params) {
    let result = {};

    for (const str of params) {
        let matches = str.match(/\w+/g);
        for (const word of matches) {
            if (result[word]) {
                result[word]++;
            } else {
                result[word] = 1;
            }
        }
    }

    return JSON.stringify(result);
}

console.log(countWords([`Far too slow, you're far too slow.`, `re`]));
