solve([
    "3",
    "6",
    "5",
    "4",
    "Stop",
    "10",
    "12"
]);

function solve(args) {
    for(item of args) {
        if (item === 'Stop') {
            return;
        }

        console.log(item);
    }
}