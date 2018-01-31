function printUniqueArrays(params) {
    let unique = new Map();

    for (const row of params) {
        let arr = JSON.parse(row).sort((a, b) => b - a);
        let stringified = `[${arr.join(', ')}]`;
        unique.set(stringified, arr.length);
    }

    let result = [...unique]
        .sort((a, b) => a[1] - b[1])
        .map(kvp => kvp[0])
        .join('\n');

    console.log(result);
}

printUniqueArrays(
    ['[7.14, 7.180, 7.339, 80.099]',
        '[7.339, 80.0990, 7.140000, 7.18]',
        '[7.339, 7.180, 7.14, 80.099]']
);