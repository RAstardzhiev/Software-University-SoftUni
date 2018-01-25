/* Arrow solution */
let specialSort = arr => {
    let result = [];

    arr.forEach(element => { element < 0 
        ? result.unshift(element)
        : result.push(element);
    });

    return result.join('\n');
};

/* Solution through function */
// function specialSort(arr) {
//     let result = [];

//     for (const num of arr) {
//         if (num < 0) {
//             result.unshift(num);
//         } else {
//             result.push(num);
//         }
//     }

//     return result.join('\n');
// } 

console.log(specialSort([7, -2, 8, 9]));
console.log();
console.log(specialSort([3, -2, 0, -1]));