/* JS Distinct variants */

/* Set tansformed back to Array by the spread operator */
/* VS Code: 0.649 seconds -> Judge: Memory: 11.24 MB / Time: 0.025 s */
// let orderUsernames = arr => [...new Set(arr)]

/* Array from Set  */
/* VS Code: 1.022 seconds -> Judge: Memory: 11.19 MB / Time: 0.025 s */
// let orderUsernames = arr => Array.from(new Set(arr))

/* Filter (value, index, self) */
/* VS Code: 0.647 seconds -> Judge: 11.15 MB / Time: 0.025 s */
let orderUsernames = arr => arr.filter((v, i, a) => a.indexOf(v) === i)
    .sort((a, b) => (a.length - b.length !== 0) ? a.length - b.length
        : a < b ? -1
            : a > b ? 1
                : 0)
    .join('\n');

console.log(orderUsernames(['Denise',
    'Ignatius',
    'Iris',
    'Isacc',
    'Indie',
    'Dean',
    'Donatello',
    'Enfuego',
    'Benjamin',
    'Biser',
    'Bounty',
    'Renard',
    'Rot']
));
