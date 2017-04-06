 solve ([
 `10`,
 `30`,
 `15`,
 `20`,
 `50`,
 `5`
 ]);

function solve(args) {
    let largestThreeNumbers = args
        .map(Number)
        .sort((a, b) => b - a)
        .slice(0, 3)
        .forEach(function (x) {
            console.log(x)
        });
}