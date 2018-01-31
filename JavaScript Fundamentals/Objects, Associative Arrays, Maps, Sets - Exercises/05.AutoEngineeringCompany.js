function printProductionStatistics(params) {
    let stat = new Map();

    for (const row of params) {
        let [brand, model, coundAsString] = row.split(' | ');
        let producedCount = Number(coundAsString);

        if (!stat.get(brand)) {
            stat.set(brand, new Map().set(model, producedCount));
        } else if (!stat.get(brand).get(model)) {
            stat.get(brand).set(model, producedCount);
        } else {
            stat.set(brand, stat.get(brand).set(model, stat.get(brand).get(model) + producedCount));
        }
    }

    let result = [...stat]
        .map(b => b[0] + '\n' + [...b[1]]
            .map(kvp => `###${kvp[0]} -> ${kvp[1]}`)
            .join('\n'))
        .join('\n');

    console.log(result);
}

printProductionStatistics(
    ['Audi | Q7 | 1000',
        'Audi | Q6 | 100',
        'BMW | X5 | 1000',
        'BMW | X6 | 100',
        'Citroen | C4 | 123',
        'Volga | GAZ-24 | 1000000',
        'Lada | Niva | 1000000',
        'Lada | Jigula | 1000000',
        'Citroen | C4 | 22',
        'Citroen | C5 | 10']
);