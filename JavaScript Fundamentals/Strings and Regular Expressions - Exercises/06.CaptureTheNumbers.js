function extractNumbers(arr) {
    let pattern = /[0-9]+/g;
    let result = '';

    for (let i = 0; i < arr.length; i++) {
        let match = pattern.exec(arr[i]);
        while (match) {
            result += match + ' ';
            match = pattern.exec(arr[i]);
        }
    }

    return result.trim();
}

console.log(extractNumbers(['The300', 'What is that?', 'I think it’s the 3rd movie.', 'Lets watch it at 22:45']));
