function printExpeditionResult(matrix, secondaryMAtrix, overlayCoordinates, startPosition) {
    let isInMatrix = (row, col) => row >= 0 && row < matrix.length && col >= 0 && col < matrix[0].length;
    overlayMatrices();
    let stepsCount = 0;
    let lastPosition = [];
    tryFindHome(startPosition[0], startPosition[1]);

    // Print results
    let result = '';
    if (lastPosition.length === 0) {
        deadEnd(startPosition[0], startPosition[1]);
    } else {
        stepsCount++;

        if (lastPosition[0] === 0) {
            result = 'Top';
        } else if (lastPosition[0] === matrix.length - 1) {
            result = 'Bottom';
        } else if (lastPosition[1] === 0) {
            result = 'Left';
        } else if (lastPosition[1] === matrix[0].length - 1) {
            result = 'Right';
        } else {
            result = deadEnd(lastPosition[0], lastPosition[1]);
        }
    }

    console.log(stepsCount + '\n' + result);

    function deadEnd(row, col) {
        // Quadrants Scheme
        // | 2 | 1 |
        // | 3 | 4 |
        let isLeftSide = col < matrix[0].length / 2; // Quadrants 2 and 3
        let isUpperSide = row < matrix.length / 2 // Quadrants 2 and 1
        let quadrant = 0;

        if (isLeftSide) {
            if (isUpperSide) {
                quadrant = 2;
            } else {
                quadrant = 3;
            }
        } else {
            if (isUpperSide) {
                quadrant = 1;
            } else {
                quadrant = 4;
            }
        }

        return `Dead end ${quadrant}`;
    }

    function tryFindHome(row, col) {
        matrix[row][col]--;

        let left = [row, col - 1];
        let right = [row, col + 1];
        let up = [row - 1, col];
        let down = [row + 1, col];

        if (isInMatrix(left[0], left[1]) && matrix[left[0]][left[1]] === 0) {
            makeAStep(left);
        } else if (isInMatrix(right[0], right[1]) && matrix[right[0]][right[1]] === 0) {
            makeAStep(right);
        } else if (isInMatrix(up[0], up[1]) && matrix[up[0]][up[1]] === 0) {
            makeAStep(up);
        } else if (isInMatrix(down[0], down[1]) && matrix[down[0]][down[1]] === 0) {
            makeAStep(down);
        }

        function makeAStep(position) {
            lastPosition = position;
            stepsCount++;
            tryFindHome(position[0], position[1]);
        }
    }

    function overlayMatrices() {
        for (const line of overlayCoordinates) {
            let [startingRow, startingCol] = line;

            for (let i = 0; i < secondaryMAtrix.length; i++) {
                for (let j = 0; j < secondaryMAtrix[i].length; j++) {
                    if (secondaryMAtrix[i][j] === 1) {
                        let currentRow = i + startingRow;
                        let currentCol = j + startingCol;

                        if (isInMatrix(currentRow, currentCol)) {
                            matrix[i + startingRow][j + startingCol]++;
                            matrix[i + startingRow][j + startingCol] %= 2;
                        }
                    }
                }
            }
        }
    }
}

printExpeditionResult(
    [[1, 1, 0, 1, 1, 1, 1, 0],
    [0, 1, 1, 1, 0, 0, 0, 1],
    [1, 0, 0, 1, 0, 0, 0, 1],
    [0, 0, 0, 1, 1, 0, 0, 1],
    [1, 0, 0, 1, 1, 1, 1, 1],
    [1, 0, 1, 1, 0, 1, 0, 0]],

    [[0, 1, 1],
    [0, 1, 0],
    [1, 1, 0]],

    [[1, 1],
    [2, 3],
    [5, 3]],

    [0, 2]
);

console.log();

printExpeditionResult(
    [[1, 1, 0, 1],
    [0, 1, 1, 0],
    [0, 0, 1, 0],
    [1, 0, 1, 0]],

    [[0, 0, 1, 0, 1],
    [1, 0, 0, 1, 1],
    [1, 0, 1, 1, 1],
    [1, 0, 1, 0, 1]],

    [[0, 0],
    [2, 1],
    [1, 0]],

    [2, 0]
);