function drawSquare(size = 5) {
    let square = '';
    let fillingSymbol = '*';

    for (let i = 1; i <= size; i++) {
        square += fillingSymbol + ` ${fillingSymbol}`.repeat(size - 1) + '\r\n';
    }

    console.log(square);
}

drawSquare(1);
drawSquare(2);
drawSquare(5);
drawSquare();