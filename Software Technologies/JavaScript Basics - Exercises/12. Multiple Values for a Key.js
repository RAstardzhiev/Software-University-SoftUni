solve([
    "key value",
    "key eulav",
    "test tset",
    "key"
]);

function solve(args) {
    let result = [];

    for(line of args) {
        let command = line.split(' ');
        if (command.length > 1) {
            if(result[command[0]] === undefined) {
                result[command[0]] = [command[1]];
            } else {
                result[command[0]].push(command[1]);
            }
        }
    }

    let key = args.pop();
    if (result[key] === undefined)
        console.log('None');
    else
        result[key].forEach(x => console.log(x));
}