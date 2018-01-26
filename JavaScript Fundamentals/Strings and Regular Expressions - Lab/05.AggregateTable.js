function printAggregatedTable(params) {
    let delimiter = '|';
    let towns = [];
    let sum = 0;

    for (let i = 0; i < params.length; i++) {
        let startIndex = params[i].indexOf(delimiter) + 1;
        let endindex = params[i].lastIndexOf(delimiter);

        let town = params[i].substring(startIndex, endindex).trim();
        let income = Number(params[i].substring(endindex + 1).trim());

        towns.push(town);
        sum += income;
    }

    console.log(towns.join(', '));
    console.log(sum);
}

printAggregatedTable(['| Sofia           | 300',
    '| Veliko Tarnovo  | 500',
    '| Yambol          | 275']
);