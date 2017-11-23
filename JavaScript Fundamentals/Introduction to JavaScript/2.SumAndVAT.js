function sumAndVAT(numbers) {
    let sum = 0;

    for (let num of numbers) {
        sum += num;
    }

    let vat = sum * 0.2;

    console.log(`sum = ${sum}`);
    console.log(`VAT = ${vat}`);
    console.log(`total = ${sum + vat}`);
}