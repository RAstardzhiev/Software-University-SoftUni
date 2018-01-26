let toLetters = str => Array
    .from(str)
    .map((ch, i) => `str[${i}] -> ${ch}`)
    .join('\n');

console.log(toLetters('Hello, World!'));
