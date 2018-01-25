let twoSmallestNumbers = arr => arr
    .sort((a, b) => a - b)
    .slice(0, 2);

console.log(twoSmallestNumbers([30, 15, 50, 5]));
console.log(twoSmallestNumbers([3, 0, 10, 4, 7, 3]));
