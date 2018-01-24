function printTreasureLocation(params) {
    for (let i = 0; i < params.length; i++) {
        let col = params[i++];
        let row = params[i];

        let location = (row >= 0 && row <= 1 && col >= 8 && col <= 9) ? 'Tokelau' 
            : (row >= 1 && row <= 3 && col >= 1 && col <= 3) ? 'Tuvalu'
            : (row >= 3 && row <= 6 && col >= 5 && col <= 7) ? 'Samoa'
            : (row >= 6 && row <= 8 && col >= 0 && col <= 2) ? 'Tonga'
            : (row >= 7 && row <= 8 && col >= 4 && col <= 9) ? 'Cook'
            : 'On the bottom of the ocean';

        console.log(location);
    }
}

printTreasureLocation([4, 2, 1.5, 6.5, 1, 3]);
console.log();
printTreasureLocation([6, 4]);