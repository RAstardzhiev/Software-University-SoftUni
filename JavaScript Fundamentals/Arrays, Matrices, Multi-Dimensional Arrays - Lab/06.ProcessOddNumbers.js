let doubledOddPositions = arr => arr
    .filter((e, i) => i % 2 !== 0)
    .reverse()
    .map(e => e * 2)
    .join(' ');

console.log(doubledOddPositions([10, 15, 20, 25]));
console.log(doubledOddPositions([3, 0, 10, 4, 7, 3]));
