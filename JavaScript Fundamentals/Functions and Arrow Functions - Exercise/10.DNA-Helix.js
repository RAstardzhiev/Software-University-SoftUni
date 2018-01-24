function printHelixDna(rows) {
    let symbols = ['A', 'T', 'C', 'G', 'T', 'T', 'A', 'G', 'G', 'G'];
    let starSequence = [2, 1, 0, 1];
    let lineSequence = [0, 2, 4, 2];

    let result = '';

    for (let i = 0; i < rows; i++) {
        let leftChar = symbols.shift();
        let rightChar = symbols.shift();
        let starCount = starSequence.shift();
        let lineCount = lineSequence.shift();
        
        let stars = '*'.repeat(starCount);
        let lines = '-'.repeat(lineCount);

        result += `${stars}${leftChar}${lines}${rightChar}${stars}\r\n`;

        symbols.push(leftChar, rightChar);
        starSequence.push(starCount);
        lineSequence.push(lineCount);
    }

    console.log(result);    
}

printHelixDna(10);