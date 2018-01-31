function collectBiottles(params) {
    let bottleCapacity = 1000;
    let bottles = new Map();
    let juiceCollection = {};

    for (const row of params) {
        let splittedRow = row.split(' => ');
        let juiceType = splittedRow[0];
        let quantity = Number(splittedRow[1]);

        if (juiceCollection[juiceType]) {
            juiceCollection[juiceType] += quantity;
        } else {
            juiceCollection[juiceType] = quantity;
        }

        if (juiceCollection[juiceType] >= bottleCapacity) {
            fillBottle(juiceType);
        }
    }

    return [...bottles]
        .map(e => `${e[0]} => ${e[1]}`)
        .join('\n');

    function fillBottle(juiceType) {
        let bottlesCount = Math.floor(juiceCollection[juiceType] / bottleCapacity);
        if (bottles.get(juiceType)) {
            bottles.set(juiceType, bottles.get(juiceType) + bottlesCount)
        } else {
            bottles.set(juiceType, bottlesCount);
        }

        juiceCollection[juiceType] = juiceCollection[juiceType] % bottleCapacity;
    }
}

console.log(collectBiottles(['Kiwi => 234',
    'Pear => 2345',
    'Watermelon => 3456',
    'Kiwi => 4567',
    'Pear => 5678',
    'Watermelon => 6789']
));
