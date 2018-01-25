let sumFirstLastNum = arr => arr.length > 1
    ? Number(arr.shift()) + Number(arr.pop())
    : Number(arr.shift()) * 2;

console.log(sumFirstLastNum(['20', '30', '40']));
console.log(sumFirstLastNum([5]));

