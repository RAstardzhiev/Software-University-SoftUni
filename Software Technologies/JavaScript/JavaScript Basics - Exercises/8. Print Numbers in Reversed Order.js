solve([
    "5",
    "5.5",
    "24",
    "-3"
]);

function solve(args) {
    args
        .reverse()
        .forEach(x => console.log(x));
}