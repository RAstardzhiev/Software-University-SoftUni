function cookNumbers(params) {
    let number = params[0];

    for (let i = 1; i < params.length; i++) {
        let action = params[i].toLowerCase();

        number = action === 'chop' ? number / 2
            : action === 'dice' ? Math.sqrt(number)
            : action === 'spice' ? number + 1
            : action === 'bake' ? number * 3
            : action === 'fillet' ? number * 0.8
            : 'Error. Wrong command!';

        console.log(number);
    }
}

cookNumbers([32, 'chop', 'chop', 'chop', 'chop', 'chop']);
console.log('*'.repeat(20));
cookNumbers([9, 'dice', 'spice', 'chop', 'bake', 'fillet']);