function cookNumbers(params) {
    let number = params[0];
    let operations = {
        chop: (n) => number / 2, 
        dice: (n) => Math.sqrt(n), 
        spice: (n) => number + 1, 
        bake: (n) => number * 3, 
        fillet: (n) => number * 0.8
    }    

    for (let i = 1; i < params.length; i++) {
        let action = params[i].toLowerCase();
        number = operations[action](number);
        console.log(number);
    }
}

cookNumbers([32, 'chop', 'chop', 'chop', 'chop', 'chop']);
console.log('*'.repeat(20));
cookNumbers([9, 'dice', 'spice', 'chop', 'bake', 'fillet']);