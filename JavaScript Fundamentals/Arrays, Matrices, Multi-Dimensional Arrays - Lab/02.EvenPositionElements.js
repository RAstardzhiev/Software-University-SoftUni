let filterArray = arr => arr
    .filter((element, index) => index % 2 === 0)
    .join(' ');

console.log(filterArray(['20', '30', '40']));
console.log();
console.log(filterArray(['5', '10']));
