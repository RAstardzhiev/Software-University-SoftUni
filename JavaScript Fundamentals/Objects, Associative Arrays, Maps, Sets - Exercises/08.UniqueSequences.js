function printUniqueArrays(params) {
    Set.prototype.containsArray = function (array) {
        let matrix = [...this];

        for (let i = 0; i < matrix.length; i++) {
            if (matrix[i].length !== array.length) {
                continue;
            }

            let areEqual = true;
            for (let j = 0; j < matrix[i].length; j++) {
                if (!matrix[i].includes(array[j])) {
                    areEqual = false;
                    break;
                }
            }

            if (areEqual) {
                return true;
            }
        }

        return false;
    }

    let unique = new Set();

    for (const row of params) {
        let arr = JSON.parse(row);
        if (!unique.containsArray(arr)) {
            unique.add(arr);
        }
    }

    console.log([...unique]
        .sort((a, b) => a.length - b.length)
        .map(a => a.sort((a, b) => b - a))
        .map(a => `[${a.join(', ')}]`)
        .join('\n')
    );
}

printUniqueArrays(
    ['[7.14, 7.180, 7.339, 80.099]',
     '[7.339, 80.0990, 7.140000, 7.18]',
     '[7.339, 7.180, 7.14, 80.099]']
);