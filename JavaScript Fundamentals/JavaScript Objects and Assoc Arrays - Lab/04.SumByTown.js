function printTownsIncome(params) {
    let towns = {};

    for (let i = 0; i < params.length; i++) {
        let name = params[i++];
        if (i === params.length) {
            break;
        }

        let income = Number(params[i]);

        // if (towns[name]) { Works the same way
        if (towns.hasOwnProperty(name)) {
            towns[name] += income;
        } else {
            towns[name] = income;
        }
    }

    console.log(JSON.stringify(towns));
}

printTownsIncome(['Sofia', '0', 'Sofia', '20', 'Varna', '3', 'Sofia', '5', 'Varna', '4']);