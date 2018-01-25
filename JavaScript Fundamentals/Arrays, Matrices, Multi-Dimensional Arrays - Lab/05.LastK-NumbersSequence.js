function printLastK(length, k) {
    let result = [1];
    
    for (let i = 1; i < length; i++) {
        let current = result.slice(k * -1)
            .reduce((a, b) => a + b);

        result[i] = current;
    }

    console.log(result.join(' '));
}

printLastK(6, 3);