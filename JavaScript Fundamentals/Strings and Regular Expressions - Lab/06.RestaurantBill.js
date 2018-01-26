function printBillSummary(params) {
    let products = [];
    let totalSum = 0;

    for (let i = 0; i < params.length; i++) {
        let prod = params[i++];
        let price = Number(params[i]);

        products.push(prod);
        totalSum += price;
    }

    console.log(`You purchased ${products.join(', ')} for a total sum of ${totalSum}`);
}

printBillSummary(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);