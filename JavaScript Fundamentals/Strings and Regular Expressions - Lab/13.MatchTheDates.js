function printDates(params) {
    let pattenr = /\b([0-9]{1,2})-([A-Z][a-z]{2})-([0-9]{4})\b/g;
    let result = '';

    for (let i = 0; i < params.length; i++) {
        let match = pattenr.exec(params[i]);
        while (match) {
            result += `${match[0]} (Day: ${match[1]}, Month: ${match[2]}, Year: ${match[3]})\n`;
            match = pattenr.exec(params[i]);
        }
    }

    console.log(result.trim());
}

printDates(['I am born on 30-Dec-1994.',
    'This is not date: 512-Jan-1996.',
    'My father is born on the 29-Jul-1955.']
);