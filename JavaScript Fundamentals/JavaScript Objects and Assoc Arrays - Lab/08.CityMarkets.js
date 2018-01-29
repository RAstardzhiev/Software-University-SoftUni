function printAggregatedTownIncome(params) {
    let arrowDelimiter = ' -> ';
    let colonDelimiter = ':';

    let stat = {};

    for (const row of params) {
        let [town, product, countAndPrice] = row.split(arrowDelimiter);
        let[soldCount, unitPrice] = countAndPrice.split(colonDelimiter)
            .map(e => Number(e));

        if (!stat[town]) {
            stat[town] = {};
        }

        if (!stat[town][product]) {
            stat[town][product] = 0;
        } 
        
        stat[town][product] += soldCount * unitPrice;
    }

    let result = '';
    for (const townName in stat) {
        result += `Town - ${townName}\n`;

        for (const productName in stat[townName]) {
            result += `$$$${productName} : ${stat[townName][productName]}\n`;
        }
    }

    console.log(result.trim());
}

printAggregatedTownIncome(['Sofia -> Laptops HP -> 200 : 2000',
    'Sofia -> Raspberry -> 200000 : 1500',
    'Sofia -> Audi Q7 -> 200 : 100000',
    'Montana -> Portokals -> 200000 : 1',
    'Montana -> Qgodas -> 20000 : 0.2',
    'Montana -> Chereshas -> 1000 : 0.3']
);