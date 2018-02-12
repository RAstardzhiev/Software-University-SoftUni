function printServey(inputText) {
    if (!/<svg>[\s\S]*<\/svg>/gm.exec(inputText)) {
        console.log('No survey found');
        return;
    }

    let pattern = /<svg>[\s\S]*?<cat>[\s\S]*?<text>[\s\S]*?\[([\s\S]+)\][\s\S]*?<\/text>[\s\S]*?<\/cat>[\s\S]*?<cat>([\s\S]+)<\/cat><\/svg>/gm;
    let match = pattern.exec(inputText);
    if (!match) {
        console.log('Invalid format');
        return;
    }

    let label = match[1];
    let votesCount = 0;
    let totalVotes = 0;
    let matches = inputText.match(/<g><val>(-{0,1}[0-9]+)<\/val>(-{0,1}[0-9]+)<\/g>/gm);
    for (const line of matches) {
        let currentVote = /<val>(-{0,1}[0-9]+)<\/val>(-{0,1}[0-9]+)/gm.exec(line);

        let value = Number(currentVote[1]);
        let count = Number(currentVote[2]);

        if (value < 1 || value > 10 || 
            count < 1 || count > 1000000) {
            continue;
        }

        votesCount += count;
        totalVotes += value * count;
    }

    if (votesCount === 0) {
        console.log(`${label}: `);
        return;
    } 

    let votesAverage = precisionRound(totalVotes * 1.0 / votesCount, 2);

    console.log(`${label}: ${votesAverage}`);

    function precisionRound(number, precision) {
        var factor = Math.pow(10, precision);
        return Math.round(number * factor) / factor;
    }
}

printServey(
    `<svg><cat><text>How do you rate the special menu? [Food - Special]</text></cat> <cat><g><val>1</val>5</g><g><val>5</val>13</g><g><val>10</val>22</g></cat></svg>`
);