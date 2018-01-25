let specialSortedArray = arr => arr.sort((a, b) =>
    a.length - b.length !== 0 ? a.length - b.length
    : a.toLowerCase() < b.toLowerCase() ? -1
    : a.toLowerCase() > b.toLowerCase() ? 1
    : 0)
    .join('\n');

console.log(specialSortedArray(['Isacc', 'Theodor', 'Jack', 'Harrison', 'George']));
