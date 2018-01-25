/* Arrow -> 0.563 seconds -> Judge -> Time: 0.040 s -> Memory: 11.24 MB  */
let increasingSequence = arr => arr
    .filter((e, i) => e >= Math.max.apply(null, arr.slice(0, i)))
    .join('\n');

/* Function -> 0.43 seconds -> Judge -> Time: 0.040 s -> Memory: 11.19 MB  */
// function increasingSequence(arr) {
//     if (arr.length === 0) {
//         return '';
//     }

//     let result = [arr[0]];

//     for (let i = 1; i < arr.length; i++) {
//         if (arr[i] >= Math.max.apply(null, arr.slice(0, i))) {
//             result.push(arr[i]);
//         }
//     }

//     return result.join('\n');
// }

console.log(increasingSequence([1, 3, 8, 4, 10, 12, 3, 2, 24]));