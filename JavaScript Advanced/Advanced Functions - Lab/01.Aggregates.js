function aggregates(params) {
    let arr = params.map(Number);
    let result = `Sum = ${arr.reduce((a, b) => a + b)}\n` +
        `Min = ${Math.min.apply(null, arr)}\n` +
        `Max = ${Math.max.apply(null, arr)}\n` +
        `Product = ${arr.reduce((a, b) => a * b)}\n` +
        `Join = ${arr.reduce((a, b) => a + '' + b)}`

    console.log(result);
}

aggregates([2, 3, 10, 5])