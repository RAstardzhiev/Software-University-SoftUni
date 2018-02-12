function printMiningStat(params) {
    let bgn = 0;
    let dayBoughtFirstBitcoin = 0;
    let bitCoinPrice = 11949.16;

    for (let i = 0; i < params.length; i++) {
        let currentGrams = Number(params[i]);
        if ((i + 1) % 3 === 0) {
            currentGrams *= 0.7;
        }

        bgn += currentGrams * 67.51;

        if (bgn >= bitCoinPrice && dayBoughtFirstBitcoin === 0) {
            dayBoughtFirstBitcoin = i + 1;
        }
    }

    let totalBitcoins = Math.floor(bgn / bitCoinPrice);
    let moneyLeft = bgn - (totalBitcoins * bitCoinPrice);

    console.log(`Bought bitcoins: ${totalBitcoins}`);
    if (totalBitcoins > 0) {
        console.log(`Day of the first purchased bitcoin: ${dayBoughtFirstBitcoin}`);
    }
    console.log(`Left money: ${moneyLeft.toFixed(2)} lv.`);

    function precisionRound(number, precision) {
        var factor = Math.pow(10, precision);
        return Math.round(number * factor) / factor;
      }
}

printMiningStat([100, 200, 300])