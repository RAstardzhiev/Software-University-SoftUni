solve(['3', '0', '-1']);

function solve(args) {
    args = args.map(Number);
    let negativeCount = 0;
    for(let i = 0; i < args.length; i++) {
        if (args[i] == 0) {
            console.log('Positive');
            return;
        }

        if (args[i] < 0)
            negativeCount++;
    }

    console.log(negativeCount % 2 == 0 ? 'Positive' : 'Negative');
}