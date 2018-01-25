function printDiagonalAttack(matrix) {
    matrix = matrix
        .map(row => row.split(' ').map(Number));

    let mainDiagonalSum = matrix.map((row, rowIndex) =>
        row.filter((e, colIndex) => rowIndex === colIndex))
        .reduce((a, b) => Number(a) + Number(b))

    let secondaryDiagonalSum = matrix
        .map((row, rowIndex) => row.filter((e, colIndex) => colIndex === row.length - 1 - rowIndex))
        .reduce((a, b) => Number(a) + Number(b));

    let isDiagonal = (row, col) => row === col || col === matrix[row].length - 1 - row;

    mainDiagonalSum !== secondaryDiagonalSum
        ? console.log(matrix.map(row => row.join(' ')).join('\n'))
        : console.log(matrix.map((row, rowIndex) => row
            .map((e, colIndex) => isDiagonal(rowIndex, colIndex)
                ? e
                : mainDiagonalSum)
            .join(' '))
            .join('\n'));
}

printDiagonalAttack(
    ['5 3 12 3 1',
        '11 4 23 2 5',
        '101 12 3 21 10',
        '1 4 5 2 2',
        '5 22 33 11 1']
);