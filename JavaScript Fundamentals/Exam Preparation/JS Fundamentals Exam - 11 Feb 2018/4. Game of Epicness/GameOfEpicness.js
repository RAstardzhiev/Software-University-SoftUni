function printWinningKingdom(inputGenerals, battles) {
    let kingdoms = getKingdoms();

    for (let i = 0; i < battles.length; i++) {
        let attacker = getGeneral(battles[i][0], battles[i][1]);
        let defender = getGeneral(battles[i][2], battles[i][3]);

        if (attacker === null || defender === null ||
            attacker.kingdom === defender.kingdom ||
            attacker.army === defender.army) {
            continue;
        }

        if (attacker.army > defender.army) {
            attacker.wins++;
            attacker.army = Math.floor(attacker.army * 1.10);
            defender.loses++;
            defender.army = Math.floor(defender.army * 0.90);
        } else {
            defender.wins++;
            defender.army = Math.floor(defender.army * 1.10);
            attacker.loses++;
            attacker.army = Math.floor(attacker.army * 0.90);
        }
    }

    // printing
    let [winningKingdom, winningGenerals] = [...kingdoms]
        .sort((a, b) => {
            // Kingdom Wins Descending
            let secondWins = b[1].map(g => g.wins).reduce((g1, g2) => g1 + g2);
            let firstWins = a[1].map(g => g.wins).reduce((g1, g2) => g1 + g2);
            let winsDiff = secondWins - firstWins;
            //let winsDiff = b[1].reduce((g1, g2) => g1.wins + g2.wins) - a[1].reduce((g1, g2) => g1.wins + g2.wins);
            if (winsDiff !== 0) {
                return winsDiff;
            }

            // Kingdom Loses Ascending
            let firstLosses = a[1].map(g => g.loses).reduce((g1, g2) => g1 + g2);
            let secondLosses = b[1].map(g => g.loses).reduce((g1, g2) => g1 + g2);
            let lossesDif = firstLosses - secondLosses;
            if (lossesDif !== 0) {
                return lossesDif
            }

            // Kingdom Name Ascending Alphabetical
            return a[0].localeCompare(b[0]);
        })[0]

    let result = `Winner: ${winningKingdom}\n`;
    for (const g of winningGenerals.sort((a, b) => b.army - a.army)) {
        result += `/\\general: ${g.general}\n` +
            `---army: ${g.army}\n` +
            `---wins: ${g.wins}\n` +
            `---losses: ${g.loses}\n`;
    }

    console.log(result.trim());

    function getGeneral(kingdomName, generalName) {
        let currentKingdom = kingdoms.get(kingdomName);
        if (!currentKingdom) {
            return null;
        }

        let general = currentKingdom.filter(g => g.general === generalName);
        if (general.length === 0) {
            return null
        }

        return general[0];
    }

    function getKingdoms() {
        let kingdoms = new Map();

        for (const line of inputGenerals) {
            let currentKingdom = kingdoms.get(line.kingdom);
            if (!currentKingdom) {
                kingdoms.set(line.kingdom, []);
                currentKingdom = kingdoms.get(line.kingdom);
            }

            let currentGeneral = currentKingdom.filter(g => g.general === line.general)[0];
            if (!currentGeneral) {
                currentGeneral = {
                    general: line.general,
                    army: line.army,
                    kingdom: line.kingdom,
                    wins: 0,
                    loses: 0
                }

                currentKingdom.push(currentGeneral);
            } else {
                currentGeneral.army += line.army;
            }
        }

        return kingdoms;
    }
}

printWinningKingdom(
    // { kingdom: String, general: String, army: Number }
    [
        { kingdom: "Maiden Way", general: "Merek", army: 5000 },
        { kingdom: "Stonegate", general: "Ulric", army: 4900 },
        { kingdom: "Stonegate", general: "Doran", army: 70000 },
        { kingdom: "YorkenShire", general: "Quinn", army: 0 },
        { kingdom: "YorkenShire", general: "Quinn", army: 2000 },
        { kingdom: "Maiden Way", general: "Berinon", army: 100000 }
    ],
    // [ "{AttackingKingdom} ", "{AttackingGeneral}", "{DefendingKingdom} ", "{DefendingGeneral}" ]
    [
        ["YorkenShire", "Quinn", "Stonegate", "Ulric"],
        ["Stonegate", "Ulric", "Stonegate", "Doran"],
        ["Stonegate", "Doran", "Maiden Way", "Merek"],
        ["Stonegate", "Ulric", "Maiden Way", "Merek"],
        ["Maiden Way", "Berinon", "Stonegate", "Ulric"]
    ]
);

console.log();
console.log('*'.repeat(50));
console.log();

printWinningKingdom(
    [{ kingdom: "Stonegate", general: "Ulric", army: 5000 },
    { kingdom: "YorkenShire", general: "Quinn", army: 5000 },
    { kingdom: "Maiden Way", general: "Berinon", army: 1000 }],

    [["YorkenShire", "Quinn", "Stonegate", "Ulric"],
    ["Maiden Way", "Berinon", "YorkenShire", "Quinn"]]
);