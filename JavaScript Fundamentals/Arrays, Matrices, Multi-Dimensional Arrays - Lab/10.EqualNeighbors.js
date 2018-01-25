function equalPairsCount(matrix) {
    let count = 0;

    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            let rightNeighbor = matrix[i][j + 1];
            if (rightNeighbor !== undefined && rightNeighbor === matrix[i][j]) {
                count++;
            }

            if (i > 0) {
                let upNeighbor = matrix[i - 1][j];
                if (upNeighbor !== undefined && upNeighbor === matrix[i][j]) {
                    count++;
                }
            }
        }
    }

    return count;
}

console.log(equalPairsCount(
    [['2', '3', '4', '7', '0'],
    ['4', '0', '5', '3', '4'],
    ['2', '3', '5', '4', '2'],
    ['9', '8', '7', '5', '4']]
));

console.log(equalPairsCount(
    [['test', 'yes', 'yo', 'ho'],
    ['well', 'done', 'yo', '6'],
    ['not', 'done', 'yet', '5']]
));

