function printCommandsResult(meals, commands) {
    let eatenMeals = 0;
    let result = '';

    let isValidIndex = i => i >= 0 && i < meals.length;
    let commandExecutor = {
        Serve: () => {
            if (meals.length > 0) {
                result += `${meals.pop()} served!\n`
            }
        },
        Eat: () => {
            if (meals.length > 0) {
                eatenMeals++;
                result += `${meals.shift()} eaten\n`
            }
        },
        Add: (portion) => {
            if (portion.length > 0) {
                meals.unshift(portion[0])
            }
        },
        Consume: (params) => {
            if (meals.length > 0) {
                let [startIndex, endIndex] = params.map(Number);
                if (isValidIndex(startIndex) && isValidIndex(endIndex)) {
                    let consumprionCount = endIndex - startIndex + 1;
                    meals.splice(startIndex, consumprionCount);
                    eatenMeals += consumprionCount;
                    result += 'Burp!\n';
                }
            }
        },
        Shift: (params) => {
            let [firstIndex, secondIndex] = params.map(Number);
            if (isValidIndex(firstIndex) && isValidIndex(secondIndex) && meals.length > 0) {
                let firstElement = meals[firstIndex];
                meals[firstIndex] = meals[secondIndex];
                meals[secondIndex] = firstElement;
            }
        }
    };

    for (const cmd of commands) {
        if (cmd === 'End') {
            break;
        }

        let splittedCommand = cmd.split(' ');
        if (commandExecutor[splittedCommand[0]]) {
            commandExecutor[splittedCommand[0]](splittedCommand.splice(1));
        }
    }

    result += meals.length === 0 ?
        'The food is gone\n'
        : 'Meals left: ' + meals.join(', ') + '\n';
    result += `Meals eaten: ${eatenMeals}`;

    console.log(result);
}

// printCommandsResult(['chicken', 'steak', 'eggs'],
//     ['Serve',
//         'Eat',
//         'End',
//         'Consume 0 1']);
// console.log();
// printCommandsResult(['fries', 'fish', 'beer', 'chicken', 'beer', 'eggs'],
//     ['Add spaghetti',
//         'Shift 0 1',
//         'Consume 1 4',
//         'End']
// );
// console.log();
// printCommandsResult(['carrots', 'apple', 'beet'],
//     ['Consume 0 2',
//         'End',]
// );
// console.log();
printCommandsResult(['bacon', 'veggies', 'chicken'],
    ['Add',
        'End']
);