function countWords(params) {
    let map = new Map();

    for (const str of params) {
        let matches = str
            .toLowerCase()
            .match(/\w+/g);

        for (const word of matches) {
            if (map.get(word)) {
                map.set(word, map.get(word) + 1);
            } else {
                map.set(word, 1);
            }
        }
    }

    return [...map.entries()]
        .sort()
        .map((kvp) => `'${kvp[0]}' -> ${kvp[1]} times`)
        .join('\n');
}

console.log(countWords(['JS devs use Node.js for server-side JS. JS devs use JS. -- JS for devs --']));
