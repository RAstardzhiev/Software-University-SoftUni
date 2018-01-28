function printVariableNames(str) {
    let pattern = /\b_([A-Za-z0-9]+)\b/g;
    let result = [];

    let match = pattern.exec(str);
    while (match) {
        result.push(match[1]);
        match = pattern.exec(str);
    }

    console.log(result.join(','));
}

printVariableNames('The _id and _age variables are both integers.');