solve([
    "5",
    "0 - 3",
    "3 - -1",
    "4 - 2"
]);

function solve(args) {
    let arrayLength = Number(args.splice(0, 1));
    let arr = [];

    for(line of args) {
        let indexValue = line.split(/\s-\s/).map(Number);
        arr[indexValue[0]] = indexValue[1];
    }

    for(let i = 0; i < arrayLength; i++) {
        console.log(arr[i] | 0);
    }
}