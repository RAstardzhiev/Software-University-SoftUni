function printLowestPrices(params) {
    let stat = new Map();

    for (const row of params) {
        let [town, product, price] = row.split('|').map(e => e.trim());

        if (!stat.get(product)) {
            stat.set(product, new Map());
        }

        stat.get(product).set(town, Number(price));
    }

    let result = '';

    for (const kvp of stat) {
        let lowestPrice = [...kvp[1]].sort((a, b) => a[1] - b[1])[0];
        result += `${kvp[0]} -> ${lowestPrice[1]} (${lowestPrice[0]})\n`;
    }

    console.log(result.trim());
}

printLowestPrices(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10']
);

console.log();

printLowestPrices(['Sofia City | Audi | 100000',
    'Sofia City | BMW | 100000',
    'Sofia City | Mitsubishi | 10000',
    'Sofia City | Mercedes | 10000',
    'Sofia City | NoOffenseToCarLovers | 0',
    'Mexico City | Audi | 1000',
    'Mexico City | BMW | 99999']
);

console.log();

printLowestPrices(['Sofia City | Audi | 100000',
    'Sofia City | BMW | 100000',
    'Sofia City | Mitsubishi | 10000',
    'Sofia City | Mercedes | 10000',
    'Sofia City | NoOffenseToCarLovers | 0',
    'Mexico City | Audi | 1000',
    'Mexico City | BMW | 99999',
    'New York City | Mitsubishi | 10000',
    'New York City | Mitsubishi | 1000',
    'Mexico City | Audi | 100000',
    'Washington City | Mercedes | 1000']
);