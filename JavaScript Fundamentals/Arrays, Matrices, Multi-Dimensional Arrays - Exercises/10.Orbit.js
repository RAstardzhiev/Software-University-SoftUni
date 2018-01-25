function printOrbitOfPoint(params) {
    [matrixRows, matrixCols, x, y] = params;

    let matrix = createMatrix();
    let currentValue = 1;
    matrix[x][y] = currentValue;

    setLayers();
    console.log(matrix.map(row => row.join(' ')).join('\n'));

    function setLayers() {
        // Above & Below
        let upRow = x - currentValue;
        let downRow = x + currentValue;
        let upDownCol = Math.max(y - currentValue, 0);

        while (upDownCol < matrixCols && upDownCol <= y + currentValue) {
            if (upRow >= 0) {
                matrix[upRow][upDownCol] = currentValue + 1;
            }

            if (downRow < matrixRows) {
                matrix[downRow][upDownCol] = currentValue + 1;
            }

            upDownCol++;
        }

        // Left & Right
        let leftRightRow = Math.max(x - currentValue, 0);
        let rightCol = y + currentValue;
        let leftCol = y - currentValue;
        
        while (leftRightRow < matrixRows && leftRightRow <= x + currentValue) {
            if (rightCol < matrixCols) {
                matrix[leftRightRow][rightCol] = currentValue + 1;
            }

            if (leftCol >= 0) {
                matrix[leftRightRow][leftCol] = currentValue + 1;
            }

            leftRightRow++;
        }

        // Check if it is completed
        currentValue++;

        if (currentValue >= matrixRows && currentValue >= matrixCols) {
            return;
        }

        setLayers();
    }

    function createMatrix() {
        let matrix = [];

        for (let i = 0; i < matrixRows; i++) {
            matrix.push(new Array(matrixCols));
        }

        return matrix;
    }
}

printOrbitOfPoint([4, 4, 0, 0]);
console.log();
printOrbitOfPoint([5, 5, 2, 2]);
console.log();
printOrbitOfPoint([3, 3, 2, 2]);