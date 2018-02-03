function printRequiredMaterial(base, step) {
    let totalMarble = 0;
    let totalStone = 0;
    let totalLapis = 0;

    let row = 0;
    let currentSize = base;
    while (currentSize > 2) {
        let marble = currentSize * 4 - 4;
        let stone = currentSize * currentSize - marble;

        totalStone += stone;

        row++;
        if (row % 5 === 0) {
            totalLapis += marble;
        } else {
            totalMarble += marble;
        }

        currentSize -= 2;
    }

    row++;
    let totalGold = currentSize === 1 ? 1 : 4;

    totalStone = Math.ceil(totalStone * step);
    totalMarble = Math.ceil(totalMarble * step);
    totalLapis = Math.ceil(totalLapis * step);
    totalGold = Math.ceil(totalGold * step);
    let piramidHeight = Math.floor(row * step);

    let result = `Stone required: ${totalStone}\n` +
        `Marble required: ${totalMarble}\n` +
        `Lapis Lazuli required: ${totalLapis}\n` +
        `Gold required: ${totalGold}\n` +
        `Final pyramid height: ${piramidHeight}`;

    return result;
}

console.log(printRequiredMaterial(11, 1));
console.log();
console.log(printRequiredMaterial(12, 1));