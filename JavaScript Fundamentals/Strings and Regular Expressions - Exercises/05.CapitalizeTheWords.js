let toTitleCase = str => str
    .replace(/\b\w+\b/g, word =>
        word.charAt(0).toUpperCase() + word.substr(1).toLowerCase());

console.log(toTitleCase('Capitalize these words'));
