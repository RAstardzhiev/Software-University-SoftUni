let sort = (arr, sortMethod) => arr.sort((a, b) => sortMethod === 'desc'
    ? b - a
    : a - b);

console.log(sort([14, 7, 17, 6, 8], 'asc'));
