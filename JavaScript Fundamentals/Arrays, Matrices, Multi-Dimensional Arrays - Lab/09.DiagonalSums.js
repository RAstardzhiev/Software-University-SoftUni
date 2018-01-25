/* Arrow solution -> 0.853 seconds -> Judge -> Time: 0.071 s -> Memory: 11.27 MB */
// let diagonalsSum = matrix => matrix.map((row, rowIndex) => 
//     row.filter((e, colIndex) => rowIndex === colIndex))
//     .reduce((a, b) => a.concat(b))
//     .reduce((a, b) => Number(a) + Number(b)) 
//     // So far Main Diagonal
//     + ' ' + 
//     // Beginning of the Secondary Diagonal
//     matrix.map((row, rowIndex) => 
//     row.filter((e, colIndex) => colIndex === row.length - 1 - rowIndex))
//     .reduce((a, b) => Number(a) + Number(b));

/* Function solution -> 0.404 seconds Judge -> Time: 0.040 s -> Memory: 11.23 MB */
function diagonalsSum(matrix) {
    let result = '';
    let mdSum = 0;

    // Main Diagonal
    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            if (i === j) {
                mdSum += matrix[i][j];
            }
        }
    }

    result += mdSum + ' ';
    let sdSum = 0;

    // Secondary Diagonal
    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            if (j === matrix[i].length - 1 - i) {
                sdSum += matrix[i][j];
            }            
        }
    }

    result += sdSum;
    return result;
}

console.log(diagonalsSum([[20, 40],
    [10, 60]]
   ));

console.log();

console.log(diagonalsSum([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]
   ));


