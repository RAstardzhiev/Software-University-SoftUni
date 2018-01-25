function isMagicMatrix(matrix) {
    let sumRow = row => matrix[row].reduce((a, b) => a + b);
    let sumCol = col => matrix.map(row => row[col])
        .reduce((a, b) => a + b);

    if (matrix.length > 0) {
        let targetSum = sumRow(0);

        for (let i = 1; i < matrix.length; i++) {
            let rowSum = sumRow(i);
            if (rowSum !== targetSum) {
                return false;
            }
        }

        for (let j = 0; j < matrix[0].length; j++) {
            let colSum = sumCol(j);
            if (colSum !== targetSum) {
                return false;
            }
        }
    }

    return true;
}

console.log(isMagicMatrix(
    [[4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]
));


console.log(isMagicMatrix(
    [[11, 32, 45],
    [21, 0, 1],
    [21, 1, 1]]
));

console.log(isMagicMatrix(
    [[1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]
));