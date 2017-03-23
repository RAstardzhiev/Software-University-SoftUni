solve([
    "key value",
    "key eulav",
    "test tset",
    "key"
]);

function solve(args) {
    let kvp = [];

    for(line of args) {
        let command = line.split(' ');
        if (command.length > 1) {
            kvp[command[0]] = command[1];
        } else {
            if (kvp[command[0]]) {
                console.log(kvp[command[0]]);
            } else {
                console.log('None')
            }
        }
    }
}