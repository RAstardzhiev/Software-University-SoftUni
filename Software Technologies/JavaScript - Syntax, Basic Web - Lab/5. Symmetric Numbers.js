solve([`750`]);

function solve(args) {
    let number = Number(args[0]);
    let result = '';

    for(let i = 1; i <= number; i++) {
        if (isSym(i))
            result += ` ${i}`;
    }

    console.log(result);

    function isSym(num) {
        num = num.toString();
        for(let i = 0; i < num.length / 2; i++) {
            if (num[i] !== num[num.length - i - 1])
                return false;
        }

        return true;
    }
}