solve([
    'add 3',
    'add 5',
    'remove 2',
    'remove 0',
    'add 7'
]);

function solve(args) {
    let arr = [];
    for(line of args) {
        let command = line.split(' ');
        let value = Number(command[1]);
        command = command[0];

        switch (command) {
            case 'add':
                arr.push(value);
                break;
            case 'remove':
                arr.splice(value, 1);
                break;
        }
    }

    arr.forEach(x => console.log(x));
}