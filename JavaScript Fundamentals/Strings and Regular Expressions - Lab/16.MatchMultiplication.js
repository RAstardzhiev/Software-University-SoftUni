function printCalculatedBill(bill) {
    let pattern = /(-{0,1}[0-9]+)\s*\*\s*(-{0,1}[0-9]+\.{0,1}[0-9]*)/g;

    let match = pattern.exec(bill);
    while (match) {
        bill = bill.replace(match[0], Number(match[1]) * Number(match[2]));
        match = pattern.exec(bill);
    }

    console.log(bill);
}

printCalculatedBill('My bill: 2*2.50 (beer); 2* 1.20 (kepab); -2  * 0.5 (deposit).');