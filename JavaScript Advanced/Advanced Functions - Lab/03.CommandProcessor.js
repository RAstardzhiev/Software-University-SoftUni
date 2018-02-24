// Without IIFE
function commandProcessor(params) {
    let commands = {
        append: str => result += str,
        removeStart: n => result = result.slice(Number(n)),
        removeEnd: n => result = result.substr(0, result.length - Number(n)),
        print: () => console.log(result)
    }

    let result = '';

    for (const line of params) {
        let [cmd, arg] = line.split(' ');
        commands[cmd](arg);
    }    
}

// Using IIFE
function commandProcessorWith_IIFE(commands) {
    let commandProcessor = (function () {
        let result = '';
        return {
            append: (str) => result += str,
            removeStart: (n) => result = result.slice(Number(n)),
            removeEnd: (n) => result = result.slice(0, result.length - Number(n)),
            print: () => console.log(result)
        }
    })();

    for (let cmd of commands) {
        let [cmdName, arg] = cmd.split(' ');
        commandProcessor[cmdName](arg);
    }
}

console.log('Withoout IIFE');

commandProcessor(
    ['append hello',
        'append again',
        'removeStart 3',
        'removeEnd 4',
        'print']
);

commandProcessor(
    ['append 123',
        'append 45',
        'removeStart 2',
        'removeEnd 1',
        'print']
);

console.log();
console.log('Using IIFE');

commandProcessorWith_IIFE(
    ['append hello',
        'append again',
        'removeStart 3',
        'removeEnd 4',
        'print']
);

commandProcessorWith_IIFE(
    ['append 123',
        'append 45',
        'removeStart 2',
        'removeEnd 1',
        'print']
);