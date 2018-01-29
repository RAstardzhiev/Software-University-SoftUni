function printTownsPopulation(params) {
    let separator = ' <-> ';
    let stat = new Map();

    for (const townData of params) {
        let indexOfSeparator = townData.indexOf(separator);
        if (indexOfSeparator < 0) {
            continue;
        }

        let name = townData.substr(0, indexOfSeparator);
        let population = Number(townData.substr(indexOfSeparator + separator.length));

        if (stat.get(name)) {
            stat.set(name, stat.get(name) + population);
        } else {
            stat.set(name, population);
        }
    }

    let result = [...stat]
        .map(kvp => `${kvp[0]} : ${kvp[1]}`)
        .join('\n');

    console.log(result);
}

printTownsPopulation(['Istanbul <-> 100000',
    'Honk Kong <-> 2100004',
    'Jerusalem <-> 2352344',
    'Mexico City <-> 23401925',
    'Istanbul <-> 1000']
);