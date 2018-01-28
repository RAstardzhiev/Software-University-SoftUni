function hideSpecialData(params) {
    let hideOptions = {
        name: (str, replacement = '|') => 
            str.replace(/\*[A-Z][A-Za-z]*(?=\t| |$)/gm, match => replacement.repeat(match.length)), 
        phoneNumber: (str, replacement = '|') => 
            str.replace(/\+[0-9\-]{10}(?=\t| |$)/gm, match => replacement.repeat(match.length)),
        id: (str, replacement = '|') => 
            str.replace(/![A-Za-z0-9]+(?=\t| |$)/gm, match => replacement.repeat(match.length)),
        username: (str, replacement = '|') => 
            str.replace(/_[A-Za-z0-9]+(?=\t| |$)/gm, match => replacement.repeat(match.length))
    };

    for (let i = 0; i < params.length; i++) {
        params[i] = hideOptions.name(params[i]);
        params[i] = hideOptions.phoneNumber(params[i]);
        params[i] = hideOptions.id(params[i]);
        params[i] = hideOptions.username(params[i]);
    }

    return params.join('\n');
}

console.log(hideSpecialData(['Agent *Ivankov was in the room when it all happened.',
    'The person in the room was heavily armed.',
    'Agent *Ivankov had to act quick in order.',
    'He picked up his phone and called some unknown number. ',
    'I think it was +555-49-796',
    "I can't really remember...",
    'He said something about "finishing work" with subject !2491a23BVB34Q and returning to Base _Aurora21',
    'Then after that he disappeared from my sight.',
    'As if he vanished in the shadows.',
    'A moment, shorter than a second, later, I saw the person flying off the top floor.',
    "I really don't know what happened there.",
    'This is all I saw, that night.',
    'I cannot explain it myself...']
));
