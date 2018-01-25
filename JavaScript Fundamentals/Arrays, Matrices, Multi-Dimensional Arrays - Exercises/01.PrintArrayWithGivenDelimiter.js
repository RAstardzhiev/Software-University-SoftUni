/* Longer version */
// let joinedArray = arr => {
//     let delimiter = arr.pop();
//     return arr.join(delimiter);
// }

/* Shortest version */
let joinedArray = arr => arr.join(arr.pop());

console.log(joinedArray(['One', 'Two', 'Three', 'Four', 'Five', '-']));
