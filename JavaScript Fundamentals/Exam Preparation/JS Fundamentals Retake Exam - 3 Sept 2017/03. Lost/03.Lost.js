function printDecriptedMessage(messageSign, text) {
    let pattern = /(north|east)[\s\S]*?([0-9]{2})[^,]*?,[^,]*?([0-9]{6})/gim;
    let mesagePattern = new RegExp(`${messageSign}([\\s\\S]*)${messageSign}`, 'gim');

    let north = '';
    let east = '';
    
    let currnetMatch = pattern.exec(text);
    while (currnetMatch) {
        if (currnetMatch[1].toLowerCase() === 'north') {
            north = `${currnetMatch[2]}.${currnetMatch[3]} N`;
        } else {
            east = `${currnetMatch[2]}.${currnetMatch[3]} E`;
        }

        currnetMatch = pattern.exec(text);
    }

    let messageContent = 'Message: ' + mesagePattern.exec(text)[1];

    console.log(north + '\n' + east + '\n' + messageContent);
}

printDecriptedMessage(
    '<>',
    'o u%&lu43t&^ftgv><nortH4276hrv756dcc,  jytbu64574655k <>ThE sanDwich is iN the refrIGErator<>yl i75evEAsTer23,lfwe 987324tlblu6b'
);

console.log();

printDecriptedMessage(
    '4ds',
    'eaSt 19,432567noRt north east 53,123456north 43,3213454dsNot all those who wander are lost.4dsnorth 47,874532'
);
