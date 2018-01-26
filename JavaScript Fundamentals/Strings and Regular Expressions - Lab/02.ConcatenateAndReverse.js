let reverseConcatenated = arr => Array
    .from(arr.join(''))
    .reverse()
    .join('');

console.log(reverseConcatenated(['I', 'am', 'student']));
console.log(reverseConcatenated(['race', 'car']));
